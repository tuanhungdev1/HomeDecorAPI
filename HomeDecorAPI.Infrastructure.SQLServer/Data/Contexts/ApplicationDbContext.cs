﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<WishlistItem> WishlistItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            modelBuilder.ApplyConfiguration(new WishlistItemConfiguration());

            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.ApplyConfiguration(new SupplierConfiguration());

            modelBuilder.ApplyConfiguration(new BrandConfiguration());

			modelBuilder.ApplyConfiguration(new DiscountConfiguration());

			modelBuilder.ApplyConfiguration(new CouponConfiguration());

			modelBuilder.ApplyConfiguration(new CartConfiguration());

			modelBuilder.ApplyConfiguration(new ReviewConfiguration());

			modelBuilder.ApplyConfiguration(new OrderConfiguration());

			modelBuilder.ApplyConfiguration(new PaymentConfiguration());

			modelBuilder.ApplyConfiguration(new AddressConfiguration());
		}
    }
}
