using Avika.Forum.LogDLL;
using Avika.Forum.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.DAO
{
    public class Repository<T> where T : class, IObject
    {
        readonly Context _context = null;
        public readonly Logger _logger = null;
        public Repository(Context context, Logger logger)
        {
            this._context = context;
            this._logger = logger;
        }
        public async Task<Pagination<T>> Get(int? page, int? qty)
        {
            try
            {
                var totalItems = this._context.Set<T>().Count();
                qty = qty == 0 ? totalItems : qty;
                var totalPages = (int)Math.Ceiling((double)totalItems / (int)qty);
                var items = this._context.Set<T>()
                    .OrderBy(c => c.Id)
                    .Skip(((int)page - 1) * (int)qty)
                    .Take((int)qty)
                    .ToList();
                var result = new Pagination<T>()
                {
                    ItemPerPage = (int)qty,
                    TotalItems = totalItems,
                    TotalPages = totalPages,
                    CurrentPage = (int)page,
                    Items = items
                };
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public async Task<T> GetId(int id)
        {
            try
            {
                return this._context.Set<T>().Find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public ICollection<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            ICollection<T> query = _context.Set<T>().Where(predicate).ToList();
            return query;
        }
        public async Task<int> Save(T TEntity)
        {
            if (TEntity.Id == 0)
            {
                return await Post(TEntity);
            }
            else
            {
                return await Put(TEntity);
            }
        }
        public async Task<int> Delete(int id)
        {
            await Task.Factory.StartNew(async () =>
            {
                var tEntity = _context.Set<T>().Find(id);
                _context.Entry<T>(tEntity).State = EntityState.Deleted;
                return await SaveAsync();
            });
            return 1;
        }
        public async Task<int> Delete(T TEntity)
        {
            _context.Entry<T>(TEntity).State = EntityState.Modified;
            return await SaveAsync();
        }
        private async Task<int> SaveAsync()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception e)
            {
                this._logger.EscribirError(e.ToString());
                return -1;
            }
        }
        async Task<int> Put(T TEntity)
        {
            try
            {
                _context.Set<T>();
                _context.Entry<T>(TEntity).State = EntityState.Modified;
                return await SaveAsync();
            }
            catch (Exception e)
            {
                this._logger.EscribirError(e.ToString());
                return await Task.FromResult<int>(-1);
            }

        }
        async Task<int> Post(T TEntity)
        {
            _context.Set<T>().Add(TEntity);
            return await SaveAsync();
        }
    }
}
