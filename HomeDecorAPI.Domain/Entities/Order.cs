using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities {
    public class Order {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public string ShippingAddress { get; set; }
        public string PaymentMethod { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal Tax { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
