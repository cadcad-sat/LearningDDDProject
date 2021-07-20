using System.Linq;
using CCS.Application.Domains.Interfaces;

namespace CCS.Application.Persistences.DbContexts
{
    /// <summary>
    /// AppDbRepository
    /// </summary>
    public class AppDbRepository : IDbRepository
    {
        /// <summary>
        /// コンテキスト
        /// </summary>
        private readonly AppDbContext _context;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="context"></param>
        public AppDbRepository(AppDbContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// コンテキストに追加する
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T Add<T>(T entity)
            where T : class
        {
            _context.Set<T>().Add(entity);

            return entity;
        }

        /// <summary>
        /// クエリーを取得する
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IQueryable<T> GetQuery<T>()
            where T : class
        {
            return _context.Set<T>().AsQueryable();
        }

        /// <summary>
        /// コンテキストから削除する
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public void Remove<T>(T entity)
            where T : class
        {
            _context.Set<T>().Remove(entity);
        }

        /// <summary>
        /// 変更を永続化する
        /// </summary>
        /// <returns></returns>
        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
