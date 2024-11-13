using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts;
using Microsoft.EntityFrameworkCore;

using HomeDecorAPI.Domain.Exceptions.NotFoundException;

namespace HomeDecorAPI.Infrastructure.SQLServer.Persistence.Repositories
{
    public class CartRepository : RepositoryBase<Cart>, ICartRepository
    {
        public CartRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }

        
    }
}