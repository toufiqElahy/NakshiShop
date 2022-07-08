#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NakshiShop.Data;
using NakshiShop.Models;

namespace NakshiShop.Controllers
{
    public class UserController : Controller
    {
        private readonly NakshiShopContext _context;

        public UserController(NakshiShopContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            return View();
        }
        public async Task<IActionResult> Cart()
        {

            return View();
        }
        public async Task<IActionResult> Checkout()//Wishlist
        {

            return View();
        }
        public async Task<IActionResult> Wishlist()//Wishlist
        {

            return View();
        }
    }
}
