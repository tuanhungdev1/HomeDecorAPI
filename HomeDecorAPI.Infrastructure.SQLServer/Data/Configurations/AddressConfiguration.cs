using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations
{
	public class AddressConfiguration: IEntityTypeConfiguration<Address>
	{
		public void Configure(EntityTypeBuilder<Address> builder)
		{

			builder.HasOne(a => a.User)
				.WithMany(u => u.Addresses)
				.HasForeignKey(a => a.UserId);
		}
	}
}
