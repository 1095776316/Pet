using Microsoft.EntityFrameworkCore;
using Pet.Core;
using Pet.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Data
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly EfDbContext _dbContext;
        public EfRepository(EfDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Table
        {
            get { return _dbContext.Set<T>(); }
        }
        public IQueryable<T> TableNoTracking
        {
            get { return _dbContext.Set<T>().AsNoTracking(); }
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            var exist =await _dbContext.Set<T>().AnyAsync(expression);
            return exist;
        }

        public async Task DeleteAsync(List<T> entities)
        {
            _dbContext.RemoveRange(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetList()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetListAsync(Expression<Func<T, bool>> expression)
        {
            var list = await _dbContext.Set<T>().Where(expression).ToListAsync();
            return list;
        }

        public async Task InsertAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task InsertAsync(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().AddRange(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().UpdateRange(entities);
            await _dbContext.SaveChangesAsync();
        }
    }
}
