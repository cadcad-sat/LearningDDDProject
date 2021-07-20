using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using MonolithWebApi.Domains.Interfaces;

namespace MonolithWebApi.Infrastructures.BlobServices
{
    /// <summary>
    /// BaseContainer
    /// </summary>
    /// <typeparam name="TEntity">TEntity</typeparam>
    public class BaseContainer<TEntity> : IBlobContainer<TEntity>
    {
        protected readonly BlobContainerClient _blobContainerClient;

        public BaseContainer(string connectionString)
        {
            var blobServiceClient = new BlobServiceClient(connectionString);
            _blobContainerClient = blobServiceClient.GetBlobContainerClient(typeof(TEntity).Name.ToLower());
        }

        /// <inheritdoc/>
        public string[] List(string prefix)
        {
            var blobs = _blobContainerClient.GetBlobs(prefix: prefix);
            var result = new List<string>();
            foreach (var b in blobs)
            {
                result.Add(b.Name);
            }

            return result.ToArray();
        }

        /// <inheritdoc/>
        public async Task<TEntity> DownloadAsync(string name)
        {
            var blob = _blobContainerClient.GetBlobClient(name);
            BlobDownloadInfo download = await blob.DownloadAsync();
            using var stream = new MemoryStream();
            await download.Content.CopyToAsync(stream);
            return await JsonSerializer.DeserializeAsync<TEntity>(stream);
        }

        /// <inheritdoc/>
        public async Task<bool> UploadAsync(string name, TEntity entity)
        {
            using var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, entity);
            var blob = _blobContainerClient.GetBlobClient(name);
            await blob.UploadAsync(stream, true);
            return true;
        }

        /// <inheritdoc/>
        public bool Remove(string name)
        {
            var blob = _blobContainerClient.GetBlobClient(name);
            blob.DeleteIfExists();
            return true;
        }
    }
}
