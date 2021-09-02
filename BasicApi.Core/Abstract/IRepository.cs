using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicApi.Core.Abstract
{
    public interface IRepository<T>
    {
        IQueryable<T> Table { get; }
        IQueryable<T> TableNoTracking { get; }
        Task<T> GetById(object id);
        Task Insert(T entity);
        Task Insert(IEnumerable<T> entities);
        Task Update(T entity);
        Task Update(IEnumerable<T> entities);
        Task Delete(T entity);
        Task Delete(IEnumerable<T> entities);
    }
}
