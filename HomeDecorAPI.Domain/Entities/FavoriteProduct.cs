using HomeDecorAPI.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class FavoriteProduct {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "User ID is required.")]
    public string UserId { get; set; }
    public User? User { get; set; }

    [Required(ErrorMessage = "Product ID is required.")]
    public int ProductId { get; set; }
    public Product? Product { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime? DateAdded { get; set; } = DateTime.UtcNow;
}
