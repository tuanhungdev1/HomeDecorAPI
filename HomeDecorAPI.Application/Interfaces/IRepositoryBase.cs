using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Interfaces {
    public interface IRepositoryBase<T> where T : class {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync(bool asNoTracking);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate, bool asNoTracking);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
