﻿using HomeDecorAPI.Domain.Common.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities
{
	public class Discount : BaseEntity
	{
		public string Name { get; set; }
		public string? Description { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal DiscountAmount { get; set; }
		public DiscountType Type { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public bool IsActive { get; set; }
	}
}
