using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Repositories {
    public sealed class RepositoryManager : IRepositoryManager {
        private readonly ApplicationDbContext _applicationContext;

        public RepositoryManager(ApplicationDbContext applicationContext) {
            _applicationContext = applicationContext;   
        }

        public async Task SaveAsync() => await _applicationContext.SaveChangesAsync();
    }
}
