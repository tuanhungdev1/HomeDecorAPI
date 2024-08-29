using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Interfaces {
    public interface IRepositoryBase<T> where T : class {
        Task<IEnumerable<T>?> GetAllAsync();
        Task<T?> GetByIdAsync(Guid id);
        Task<IEnumerable<T>?> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
        Task<int?> CountAsync(Expression<Func<T, bool>>? predicate = null);
        Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    }
}
