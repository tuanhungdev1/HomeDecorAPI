﻿using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations
{
	public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
	{
		public void Configure(EntityTypeBuilder<Coupon> builder)
		{
			builder.HasKey(c => c.Id);
			
		}
	}
}