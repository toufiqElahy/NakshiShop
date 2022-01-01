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
                        ImagePath = "https://scontent.fdac31-1.fna.fbcdn.net/v/t39.30808-6/269609049_6536568336415485_3698118037027465735_n.jpg?_nc_cat=106&ccb=1-5&_nc_sid=0debeb&_nc_eui2=AeET98V14eJxM9lvRCdymOPBxFFyO051WfrEUXI7TnVZ-lFNtmeu_xCXTqTm2CpRdtGYBj6js5fj5vFXS1o_k2ne&_nc_ohc=hlSMnb3fqYoAX8ba1Yg&_nc_ht=scontent.fdac31-1.fna&oh=00_AT9a_fX68O2oW_-QwcRepqvx2C251rWyFuL4J2H-hVoVfQ&oe=61CCA12B",
                        Catagory = "Cushion",
                        Size = "16/16",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 400M
                    },

                    new Product
                    {
                        ImagePath = "https://scontent.fdac33-2.fna.fbcdn.net/v/t1.6435-9/120701970_4389523247786682_6776159043782238562_n.jpg?_nc_cat=111&ccb=1-5&_nc_sid=8bfeb9&_nc_ohc=qOFrcfFgloIAX8U9K7S&_nc_ht=scontent.fdac33-2.fna&oh=00_AT_ii9w_amM1QiAC1FO4iKITd0dOd5EztoSWrqG2Gf4SrA&oe=61EF59A8",
                        Catagory = "Sofa set mate",
                        Size = "M",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 2800M
                    },

                    new Product
                    {
                        ImagePath = "https://scontent.fdac33-2.fna.fbcdn.net/v/t1.6435-9/52948737_2460719797333713_4455381953683652608_n.jpg?_nc_cat=109&ccb=1-5&_nc_sid=0debeb&_nc_ohc=rJshnSpPpwsAX8oNX46&_nc_ht=scontent.fdac33-2.fna&oh=00_AT9AQJPIsIsaLRCXtVNZLgw_rtJ4WHlzqaa_Y61F9J_kzQ&oe=61ED7FF8",
                        Catagory = "Table Runner",
                        Size = "L",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 3000M
                    },

                    new Product
                    {
                        ImagePath = "https://scontent.fdac33-2.fna.fbcdn.net/v/t1.6435-9/45212703_2226078717464490_3030892566053650432_n.jpg?_nc_cat=100&ccb=1-5&_nc_sid=0debeb&_nc_ohc=EeaNeXb5CWAAX-aM4wQ&_nc_ht=scontent.fdac33-2.fna&oh=00_AT9LDXYuInd4y9dd99HWl-ZvXCaGjamGBFm-ieXIC5DRFg&oe=61EBDD81",
                        Catagory = "Table Clothe",
                        Size = "L",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 1000M
                    },
                    new Product
                    {
                        ImagePath = "https://scontent.fdac33-2.fna.fbcdn.net/v/t39.30808-6/218030699_5679536258785368_5250219644285296707_n.jpg?_nc_cat=102&ccb=1-5&_nc_sid=0debeb&_nc_ohc=ykT7At7VljUAX8douKB&_nc_ht=scontent.fdac33-2.fna&oh=00_AT8Ot6-vuziNVgEERIC1BUIOBfwtXY_vXnnFmgMRev_zvg&oe=61CD0862",
                        Catagory = "Yokh",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 700M
                    },
                    new Product
                    {
                        ImagePath = "https://scontent.fdac33-2.fna.fbcdn.net/v/t39.30808-6/218237425_5689680564437604_4122979711421241000_n.jpg?_nc_cat=101&ccb=1-5&_nc_sid=0debeb&_nc_ohc=TZI0J3LOumIAX8-b6Mg&_nc_oc=AQneUbdNdyQ7nqpGk2OhzLHure5rCMEQJELCloVR8N7TxWekI0vP6mlbwtOSy3aaIzQ&_nc_ht=scontent.fdac33-2.fna&oh=00_AT_jVaJZGyUt6XRwhYkWk3ptl4QaVLYBb42oWWEeypxZ6A&oe=61CC733E",
                        Catagory = "Baby Dress",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 200M
                    },
                    new Product
                    {
                        ImagePath = "https://scontent.fdac33-2.fna.fbcdn.net/v/t39.30808-6/233826769_5792372777501715_7883740570088011921_n.jpg?_nc_cat=110&ccb=1-5&_nc_sid=0debeb&_nc_ohc=LjCpvJ-0ZlQAX8Y7iV3&_nc_ht=scontent.fdac33-2.fna&oh=00_AT_06esGiqSmgXZU9r6DSABSNi7Bgt3XsJDRiSvBrxhXHw&oe=61CC3F29",
                        Catagory = "Baby sandel",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha. But the embroidery of the Nakshi Katha itself also paints a picture of life in rural Bengal.",
                        Price = 150M
                    },
                    new Product
                    {
                        ImagePath = "https://scontent.fdac33-2.fna.fbcdn.net/v/t39.30808-6/223792999_5728475853891408_2246846823699398051_n.jpg?_nc_cat=102&ccb=1-5&_nc_sid=0debeb&_nc_ohc=1Jwd8ptlK6EAX-pT481&_nc_ht=scontent.fdac33-2.fna&oh=00_AT_NlWzRfZmYNkbJ9RJiuKlXLRkRdj5MVFUjoBYohdkW3w&oe=61CCC7DD",
                        Catagory = "Baby Katha",
                        Size = "S",
                        Quantity = 1,
                        Description = "Is it stories such as this, or the intricacy of the weaves that made the Nakshi Kantha into an icon in Bengali folklore? It is true that such tales have endeared us to the humble Nakshi Kantha.",
                        Price = 450M
                    },
                    new Product
                    {
                        ImagePath = "https://scontent.fdac33-2.fna.fbcdn.net/v/t1.6435-9/129912081_4665778250161179_4359152000613719218_n.jpg?_nc_cat=106&ccb=1-5&_nc_sid=0debeb&_nc_ohc=s5aM3-zGoXMAX_H3ULL&_nc_ht=scontent.fdac33-2.fna&oh=00_AT9_KevzjjPmZCijt5GJwt9d9tZPcMNj370CdXwilKkMQg&oe=61ECA08C",
                        Catagory = "Baby Pillow Set",
                        Size = "M",
                        Quantity = 1,
                        Description = "D",
                        Price = 1200M
                    },
                    new Product
                    {
                        ImagePath = "https://scontent.fdac33-2.fna.fbcdn.net/v/t39.30808-6/270189910_6583738211698497_7676592541952506804_n.jpg?_nc_cat=103&ccb=1-5&_nc_sid=0debeb&_nc_ohc=eP9OI4iTCHgAX-Qvq9n&_nc_ht=scontent.fdac33-2.fna&oh=00_AT_uGGLP86QhrZq1gWfojmRdM3oOX9foVRBd2hMRlIRA-Q&oe=61CDA917",
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
                        ImagePath = "https://scontent.fdac33-2.fna.fbcdn.net/v/t39.30808-6/269744249_6553856288020023_1663570895510043917_n.jpg?_nc_cat=100&ccb=1-5&_nc_sid=0debeb&_nc_ohc=66gGJ4r30-4AX_8rDnX&_nc_ht=scontent.fdac33-2.fna&oh=00_AT_2uQixt9-cdbMkHDVm8Qq7PHrTY_CS1XZO4zilsty6GA&oe=61CD32FF",
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
