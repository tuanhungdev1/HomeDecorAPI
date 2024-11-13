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
	public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
	{
		public void Configure(EntityTypeBuilder<Payment> builder)
		{
			
			builder.HasOne(p => p.Order)
				.WithOne(o => o.Payment)
				.HasForeignKey<Payment>(p => p.OrderId)
				.OnDelete(DeleteBehavior.Restrict);

			
			builder.HasOne(p => p.User)
				.WithMany(u => u.Payments)
				.HasForeignKey(p => p.UserId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
