using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Repositories {
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class {
        protected ApplicationDbContext _applicationContext;
        public RepositoryBase(ApplicationDbContext applicationContext)
            => _applicationContext = applicationContext;

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
            _applicationContext.Set<T>().AsNoTracking() :
            _applicationContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
            _applicationContext.Set<T>().Where(expression).AsNoTracking() :
            _applicationContext.Set<T>().Where(expression);

        public void Create(T entity) => _applicationContext.Set<T>().Add(entity);
        public void Update(T entity) => _applicationContext.Set<T>().Update(entity);
        public void Delete(T entity) => _applicationContext.Set<T>().Remove(entity);
    }
}
