using HomeDecorAPI.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class WishlistItem : BaseEntity {
    public User User { get; set; }
    public string UserId { get; set; }
    public int ProductVariantId { get; set; }
	public ProductVariant ProductVariant { get; set; }
	public DateTime DateAdded { get; set; } = DateTime.UtcNow;
}
