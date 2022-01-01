using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NakshiShop.Models
{
    public static class StaticData
    {
        public static SelectList?  Catagories { get; set; }
        public static string? ProductCatagory { get; set; }
    }
}
 