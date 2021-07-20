using System.Threading.Tasks;

namespace MonolithWebApi.Domains.Interfaces
{
    public interface IBlobContainer<TEntity>
    {
        /// <summary>
        /// List
        /// </summary>
        /// <param name="prefix">prefix</param>
        /// <returns>一覧</returns>
        public string[] List(string prefix);

        /// <summary>
        /// DownloadAsync
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<TEntity> DownloadAsync(string name);

        /// <summary>
        /// UploadAsync
        /// </summary>
        /// <param name="name"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task<bool> UploadAsync(string name, TEntity entity);

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Remove(string name);
    }
}
