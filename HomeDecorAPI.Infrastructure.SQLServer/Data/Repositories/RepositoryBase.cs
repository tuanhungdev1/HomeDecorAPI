using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Repositories {
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        protected RepositoryBase(ApplicationDbContext context) {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync() {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid id) {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate) {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public virtual async Task AddAsync(T entity) {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync(); // Lưu thay đổi một cách bất đồng bộ
        }

        public virtual async Task AddRangeAsync(IEnumerable<T> entities) {
            await _dbSet.AddRangeAsync(entities);
            await _context.SaveChangesAsync(); // Lưu thay đổi một cách bất đồng bộ
        }

        public virtual async Task UpdateAsync(T entity) {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync(); // Lưu thay đổi một cách bất đồng bộ
        }

        public virtual async Task RemoveAsync(T entity) {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync(); // Lưu thay đổi một cách bất đồng bộ
        }

        public virtual async Task RemoveRangeAsync(IEnumerable<T> entities) {
            _dbSet.RemoveRange(entities);
            await _context.SaveChangesAsync(); // Lưu thay đổi một cách bất đồng bộ
        }

        public virtual async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null) {
            return predicate == null
                ? await _dbSet.CountAsync()
                : await _dbSet.CountAsync(predicate);
        }

        public virtual async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate) {
            return await _dbSet.AnyAsync(predicate);
        }

        public virtual async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate) {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }
    }
}
