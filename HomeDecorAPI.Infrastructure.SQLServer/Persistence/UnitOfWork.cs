using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Persistence {
    public class UnitOfWork : IUnitOfWork {
        private readonly ApplicationDbContext _context;
        private IDbContextTransaction? _objTran = null;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateTransaction() {
            _objTran = _context.Database.BeginTransaction();
        }

        public void Commit() {
            _objTran?.Commit();
        }

        public void Rollback() {
            _objTran?.Rollback();

            _objTran?.Dispose();
        }

        public async Task SaveChangesAsync() {
            try {
                await _context.SaveChangesAsync();
            } catch(DbUpdateException ex) {
                throw new Exception(ex.Message , ex);
            }
        }

        public void Dispose() {
            _context.Dispose();
        }
    }
}
