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
	public class ReviewConfiguration : IEntityTypeConfiguration<Review>
	{
		public void Configure(EntityTypeBuilder<Review> builder)
		{
			

			builder.HasOne(r => r.Product)
				.WithMany(p => p.Reviews)
				.HasForeignKey(r => r.ProductId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
