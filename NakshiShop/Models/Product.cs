using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NakshiShop.Models
{
    public class Product
    {
        public int Id { get; set; }

        //[StringLength(60, MinimumLength = 3)]
        //[Required]
        //public string? Title { get; set; }


        [Required]
        [StringLength(20)]
        public string? Catagory { get; set; }

        [Required]
        [StringLength(10)]
        public string Size { get; set; }


        //[DataType(DataType.Currency)]
        public int Quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }


        //[DataType(DataType.)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Price { get; set; }


        [StringLength(50)]
        [Required]
        public string ImagePath { get; set; }
    }
}
