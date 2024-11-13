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
	public class CartConfiguration : IEntityTypeConfiguration<Cart>
	{
		public void Configure(EntityTypeBuilder<Cart> builder)
		{
			
			builder.HasOne(c => c.AppliedDiscount)
				.WithMany()
				.HasForeignKey(c => c.AppliedDiscountId)
				.OnDelete(DeleteBehavior.SetNull);

			builder.HasOne(c => c.AppliedCoupon)
				.WithMany()
				.HasForeignKey(c => c.AppliedCouponId)
				.OnDelete(DeleteBehavior.SetNull);

			
			builder.HasOne(c => c.User)
				.WithMany(u => u.Carts)
				.HasForeignKey(c => c.UserId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
