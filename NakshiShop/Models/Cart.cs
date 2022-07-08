using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NakshiShop.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; } = 1;

        public string Status { get; set; } = "Active";

        public decimal Total { get; set; }

        public Product Product { get; set; }
        public Order? Order { get; set; }
        public string Ip { get; set; }
    }
}
