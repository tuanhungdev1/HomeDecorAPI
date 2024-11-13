using HomeDecorAPI.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class WishlistItem : BaseEntity {
    public int WishlistId { get; set; }
    public Wishlist Wishlish { get; set; }
    public int ProductVariantId { get; set; }
	public ProductVariant ProductVariant { get; set; }
	public DateTime DateAdded { get; set; } = DateTime.UtcNow;
}
