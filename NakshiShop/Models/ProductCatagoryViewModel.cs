using Microsoft.AspNetCore.Mvc.Rendering;

namespace NakshiShop.Models
{
    public class ProductCatagoryViewModel
    {
        public List<Product>? Products { get; set; }
        public SelectList? Catagories { get; set; }
        public string? ProductCatagory { get; set; }
        public string? SearchString { get; set; }
    }
}
