using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pet.Core.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(object id);


        void Insert(T entity);

        void Insert(IEnumerable<T> entities);

        void Update(T entity);

        void Update(IEnumerable<T> entities);

        void Delete(IEnumerable<T> entities);

        IQueryable<T> Table { get; set; }

        IQueryable<T> TableNoTracking { get; set; }
    }
}
