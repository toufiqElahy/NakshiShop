using Microsoft.EntityFrameworkCore;
using NakshiShop.Data;

namespace NakshiShop.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NakshiShopContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<NakshiShopContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        ImagePath = "",
                        Catagory = "Cushion",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },

                    new Product
                    {
                        ImagePath = "",
                        Catagory = "Sofa set mate",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },

                    new Product
                    {
                        ImagePath = "",
                        Catagory = "Table Runner",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },

                    new Product
                    {
                        ImagePath = "",
                        Catagory = "Table Clothe",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },
                    new Product
                    {
                        ImagePath = "",
                        Catagory = "Yokh",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },
                    new Product
                    {
                        ImagePath = "",
                        Catagory = "Baby Dress",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },
                    new Product
                    {
                        ImagePath = "",
                        Catagory = "Baby sandel",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },
                    new Product
                    {
                        ImagePath = "",
                        Catagory = "Baby Katha",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },
                    new Product
                    {
                        ImagePath = "",
                        Catagory = "Baby Pillow Set",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },
                    new Product
                    {
                        ImagePath = "",
                        Catagory = "Wall-mate",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },
                    new Product
                    {
                        ImagePath = "",
                        Catagory = "Fridge Handle Cover",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },
                    new Product
                    {
                        ImagePath = "",
                        Catagory = "Glass Cap",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
