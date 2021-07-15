using System.IO;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace CCS.MonolithWebApi.Infrastructures.BlobServices
{
    public class SampleContainer
    {
        private string connectionString = "";
        private BlobContainerClient _blobContainerClient;

        public SampleContainer()
        {
            var blobServiceClient = new BlobServiceClient(connectionString);
            _blobContainerClient = blobServiceClient.GetBlobContainerClient("sample");
        }

        public void Upload(string blobName, Stream stream)
        {
            var blob = _blobContainerClient.GetBlobClient(blobName);
            BlobContentInfo content = blob.Upload(stream, true);
        }
    }
}
