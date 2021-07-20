using System.Linq;

namespace MonolithWebApi.Domains.Interfaces
{
    public interface IDbRepository
    {
        /// <summary>
        /// コンテキストに追加する
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Add<T>(T entity) where T : class;

        /// <summary>
        /// クエリーを取得する
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IQueryable<T> GetQuery<T>() where T : class;

        /// <summary>
        /// コンテキストから削除する
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Remove<T>(T entity) where T : class;

        /// <summary>
        /// 変更を永続化する
        /// </summary>
        /// <returns></returns>
        int Commit();
    }
}
