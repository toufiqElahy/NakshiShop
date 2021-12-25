#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NakshiShop.Models;

namespace NakshiShop.Data
{
    public class NakshiShopContext : DbContext
    {
        public NakshiShopContext (DbContextOptions<NakshiShopContext> options)
            : base(options)
        {
        }

        public DbSet<NakshiShop.Models.Product> Product { get; set; }
    }
}
