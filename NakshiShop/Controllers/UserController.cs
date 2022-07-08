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
            var ip = HttpContext.Connection.RemoteIpAddress.ToString();
            var orders = await _context.Order.Include(x => x.Carts).Where(x => x.Ip == ip).ToListAsync();
            return View(orders);
        }
        public async Task<IActionResult> Cart()
        {
            var ip = HttpContext.Connection.RemoteIpAddress.ToString();
            var carts = await _context.Cart.Include(x=>x.Product).Where(x => x.Ip == ip &&x.Status=="Active").ToListAsync();
            return View(carts);
        }
        public async Task<IActionResult> Checkout()//Wishlist
        {

            return View();
        }
        public async Task<IActionResult> Wishlist()//Wishlist
        {

            return View();
        }
        public async Task<IActionResult> AddCart(int pid)//Wishlist
        {
            var ip = HttpContext.Connection.RemoteIpAddress.ToString();
            var product = _context.Product.First(x => x.Id == pid);
            var cart = new Cart();
            cart.ProductId= pid;
            cart.Total = cart.Quantity * product.Price;
            cart.Ip = ip;
            cart.Product = product;

            _context.Add(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index","Products");
            //return RedirectToAction("Details", "Products", new { id=pid});
        }
        public async Task<IActionResult> RemoveCart(int cid)//Wishlist
        {
            var ip = HttpContext.Connection.RemoteIpAddress.ToString();
            var cart = _context.Cart.First(x => x.Id == cid);
           

            _context.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction("Cart");
        }
        public async Task<IActionResult> PlaceOrder(decimal total)//Wishlist
        {
            var ip = HttpContext.Connection.RemoteIpAddress.ToString();
            var order = new Order();
            order.Ip = ip;
            order.Total = total;
            order.Status = "InProgress";

            var carts = await _context.Cart.Include(x => x.Product).Where(x => x.Ip == ip && x.Status == "Active").ToListAsync();
            //foreach (var item in carts)
            //{
            //    item.Status = "InActive";
            //    item.Order = order;
            //    item.OrderId = order.Id;
            //}

            _context.RemoveRange(carts);
            _context.Add(order);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
