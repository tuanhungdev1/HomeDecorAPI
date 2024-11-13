using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations
{
	public class OrderConfiguration : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{
			
			builder.HasOne(o => o.User)
				.WithMany(u => u.Orders)
				.HasForeignKey(o => o.UserId)
				.OnDelete(DeleteBehavior.Restrict);

			
			builder.HasMany(o => o.OrderItems)
				.WithOne(ol => ol.Order)
				.HasForeignKey(ol => ol.OrderId)
				.OnDelete(DeleteBehavior.Cascade);

			
			builder.HasOne(o => o.Payment)
				.WithOne(p => p.Order)
				.HasForeignKey<Payment>(p => p.OrderId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
