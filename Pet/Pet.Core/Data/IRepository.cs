using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Core.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(object id);

        Task InsertAsync(T entity);

        Task InsertAsync(IEnumerable<T> entities);

        Task UpdateAsync(T entity);

        Task UpdateAsync(IEnumerable<T> entities);

        Task DeleteAsync(T entity);

        Task DeleteAsync(List<T> entities);

        Task<IEnumerable<T>> GetList();

        Task<List<T>> GetListAsync(Expression<Func<T, bool>> expression);

        IQueryable<T> Table { get; }

        IQueryable<T> TableNoTracking { get; }

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
    }
}
