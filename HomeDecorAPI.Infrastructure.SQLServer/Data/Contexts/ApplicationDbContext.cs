using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Contexts {
    public class ApplicationDbContext : IdentityDbContext<User> {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<FavoriteProduct> FavoriteProducts { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            

            modelBuilder.Entity<User>()
                .HasMany(u => u.FavoriteProducts)
                .WithOne(f => f.User);


            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

        }
    }
}
