using Microsoft.AspNetCore.Mvc.Rendering;
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
                    //catagories dropdownlist from database
                    RetriveCatgories(context);
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        ImagePath = "cushion1.jpg",
                        Catagory = "Cushion",
                        Size = "16/16",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 400M
                    },

                    new Product
                    {
                        ImagePath = "cushion1.jpg",
                        Catagory = "Sofa set mate",
                        Size = "M",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 2800M
                    },

                    new Product
                    {
                        ImagePath = "runner.jpg",
                        Catagory = "Table Runner",
                        Size = "L",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 3000M
                    },

                    new Product
                    {
                        ImagePath = "tableclothe.jpg",
                        Catagory = "Table Clothe",
                        Size = "L",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 1000M
                    },
                    new Product
                    {
                        ImagePath = "yock.jpg",
                        Catagory = "Yokh",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 700M
                    },
                    new Product
                    {
                        ImagePath = "baby.jpg",
                        Catagory = "Baby Dress",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 200M
                    },
                    new Product
                    {
                        ImagePath = "sandel.jpg",
                        Catagory = "Baby sandel",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 150M
                    },
                    new Product
                    {
                        ImagePath = "baby.jpg",
                        Catagory = "Baby Katha",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha.",
                        Price = 450M
                    },
                    new Product
                    {
                        ImagePath = "baby.jpg",
                        Catagory = "Baby Pillow Set",
                        Size = "M",
                        Quantity = 1,
                        Description = "D",
                        Price = 1200M
                    },
                    new Product
                    {
                        ImagePath = "wall1.jpg",
                        Catagory = "Wall-mate",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha.",
                        Price = 600M
                    },
                    new Product
                    {
                        ImagePath = "https://scontent.fdac33-2.fna.fbcdn.net/v/t39.30808-6/228092890_5757828270956166_4104899000445219488_n.jpg?_nc_cat=104&ccb=1-5&_nc_sid=0debeb&_nc_ohc=Dq8zBgf4G7MAX8tB5xg&_nc_ht=scontent.fdac33-2.fna&oh=00_AT_li2-Z2uHc76AafjubAfkgAl75Xq-6jIoX_2xPYPDmGA&oe=61CC3462",
                        Catagory = "Fridge Handle Cover",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha.",
                        Price = 170M
                    },
                    new Product
                    {
                        ImagePath = "wall2.jpg",
                        Catagory = "Wall-mate",
                        Size = "M",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 600M
                    },

                    new Product
                    {
                        ImagePath = "cushion2.jpg",
                        Catagory = "Cushion",
                        Size = "L",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 400M
                    },

                    new Product
                    {
                        ImagePath = "cushion3.jpg",
                        Catagory = "Cushion",
                        Size = "L",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 400M
                    },
                    new Product
                    {
                        ImagePath = "wall2.jpg",
                        Catagory = "Wall-mate",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 700M
                    },
                    new Product
                    {
                        ImagePath = "wall3.jpg",
                        Catagory = " Wall-mate",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 200M
                    },
                    new Product
                    {
                        ImagePath = "wall4.jpg",
                        Catagory = "Wall-mate",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 150M
                    },
                    new Product
                    {
                        ImagePath = "round1.jpg",
                        Catagory = "Baby Katha",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha.",
                        Price = 450M
                    },
                    new Product
                    {
                        ImagePath = "round2.jpg",
                        Catagory = "Cushion",
                        Size = "M",
                        Quantity = 1,
                        Description = "D",
                        Price = 1200M
                    },
                    new Product
                    {
                        ImagePath = "round3.jpg",
                        Catagory = "Cushion",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha.",
                        Price = 600M
                    },
                    new Product
                    {
                        ImagePath = "round4.jpg",
                        Catagory = "Cushion",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha.",
                        Price = 170M
                    },
                    new Product
                    {
                        ImagePath = "cushion1.jpg",
                        Catagory = "Cushion",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha.",
                        Price = 150M
                    },
                    new Product
                    {
                        ImagePath = "glass1.jpg",
                        Catagory = "Glass Cap",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha.",
                        Price = 150M
                    }
                );
                context.SaveChanges();

                //catagories dropdownlist from database
                RetriveCatgories(context);
            }

        }

        public static void RetriveCatgories(NakshiShopContext context)
        {
            IQueryable<string> catagoryQuery = from m in context.Product
                                               orderby m.Catagory
                                               select m.Catagory;
            StaticData.Catagories = new SelectList(catagoryQuery.Distinct().ToList());

        }
    }
}
