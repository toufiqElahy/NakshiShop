using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NakshiShop.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }=DateTime.Now;

        public string Status { get; set; } = "Pending";

        public decimal Total { get; set; }

        public List<Cart> Carts { get; set; }
        public string Ip { get; set; }
    }
}
