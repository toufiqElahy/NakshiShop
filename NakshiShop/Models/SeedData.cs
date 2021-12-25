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
                        ImagePath = "https://scontent.fdac31-1.fna.fbcdn.net/v/t39.30808-6/269609049_6536568336415485_3698118037027465735_n.jpg?_nc_cat=106&ccb=1-5&_nc_sid=0debeb&_nc_eui2=AeET98V14eJxM9lvRCdymOPBxFFyO051WfrEUXI7TnVZ-lFNtmeu_xCXTqTm2CpRdtGYBj6js5fj5vFXS1o_k2ne&_nc_ohc=hlSMnb3fqYoAX8ba1Yg&_nc_ht=scontent.fdac31-1.fna&oh=00_AT9a_fX68O2oW_-QwcRepqvx2C251rWyFuL4J2H-hVoVfQ&oe=61CCA12B",
                        Catagory = "Cushion",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },

                    new Product
                    {
                        ImagePath = "https://scontent.fdac31-1.fna.fbcdn.net/v/t39.30808-6/269559393_6536571556415163_4254688267644608230_n.jpg?_nc_cat=107&ccb=1-5&_nc_sid=0debeb&_nc_eui2=AeEqiuQw_jKdwUvIuuFw7uxWzE-QAFE6H0zMT5AAUTofTGM76l9rcpOvDOHQ1j2vBPXBQhoAurUNnml6UrGe-eGx&_nc_ohc=d4uzB30dM4EAX-0M33-&tn=lNyU9fGEqdU_KqpQ&_nc_ht=scontent.fdac31-1.fna&oh=00_AT97uNA9rJJeEoL2XZtFF355ZBo-D9m2eXZFfZBbi9EJLg&oe=61CBF093",
                        Catagory = "Sofa set mate",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },

                    new Product
                    {
                        ImagePath = "https://scontent.fdac31-1.fna.fbcdn.net/v/t39.30808-6/269559393_6536571556415163_4254688267644608230_n.jpg?_nc_cat=107&ccb=1-5&_nc_sid=0debeb&_nc_eui2=AeEqiuQw_jKdwUvIuuFw7uxWzE-QAFE6H0zMT5AAUTofTGM76l9rcpOvDOHQ1j2vBPXBQhoAurUNnml6UrGe-eGx&_nc_ohc=d4uzB30dM4EAX-0M33-&tn=lNyU9fGEqdU_KqpQ&_nc_ht=scontent.fdac31-1.fna&oh=00_AT97uNA9rJJeEoL2XZtFF355ZBo-D9m2eXZFfZBbi9EJLg&oe=61CBF093",
                        Catagory = "Table Runner",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },

                    new Product
                    {
                        ImagePath = "https://scontent.fdac31-1.fna.fbcdn.net/v/t39.30808-6/269559393_6536571556415163_4254688267644608230_n.jpg?_nc_cat=107&ccb=1-5&_nc_sid=0debeb&_nc_eui2=AeEqiuQw_jKdwUvIuuFw7uxWzE-QAFE6H0zMT5AAUTofTGM76l9rcpOvDOHQ1j2vBPXBQhoAurUNnml6UrGe-eGx&_nc_ohc=d4uzB30dM4EAX-0M33-&tn=lNyU9fGEqdU_KqpQ&_nc_ht=scontent.fdac31-1.fna&oh=00_AT97uNA9rJJeEoL2XZtFF355ZBo-D9m2eXZFfZBbi9EJLg&oe=61CBF093",
                        Catagory = "Table Clothe",
                        Size = "S",
                        Quantity = 1,
                        Description = "D",
                        Price = 40M
                    },
                    new Product
                    {
                        ImagePath = "https://scontent.fdac31-1.fna.fbcdn.net/v/t39.30808-6/269559393_6536571556415163_4254688267644608230_n.jpg?_nc_cat=107&ccb=1-5&_nc_sid=0debeb&_nc_eui2=AeEqiuQw_jKdwUvIuuFw7uxWzE-QAFE6H0zMT5AAUTofTGM76l9rcpOvDOHQ1j2vBPXBQhoAurUNnml6UrGe-eGx&_nc_ohc=d4uzB30dM4EAX-0M33-&tn=lNyU9fGEqdU_KqpQ&_nc_ht=scontent.fdac31-1.fna&oh=00_AT97uNA9rJJeEoL2XZtFF355ZBo-D9m2eXZFfZBbi9EJLg&oe=61CBF093",
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
