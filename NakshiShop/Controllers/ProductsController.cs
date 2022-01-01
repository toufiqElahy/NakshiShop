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
    public class ProductsController : Controller
    {
        private readonly NakshiShopContext _context;

        public ProductsController(NakshiShopContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index(string productCatagory, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> catagoryQuery = from m in _context.Product
                                            orderby m.Catagory
                                            select m.Catagory;
            var products = from m in _context.Product
                        select m;
            ///hennas.ToList();
            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Catagory!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(productCatagory))
            {
                products = products.Where(x => x.Catagory == productCatagory);
            }

            var productCatagoryVM = new ProductCatagoryViewModel
            {
                Catagories = new SelectList(await catagoryQuery.Distinct().ToListAsync()),
                Products = await products.ToListAsync()
            };

            return View(productCatagoryVM);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public async Task<IActionResult> Create()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Product
                                            orderby m.Catagory
                                            select m.Catagory;

            var catagories = new SelectList(await genreQuery.Distinct().ToListAsync());
            ViewBag.catagories = catagories;

            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Catagory,Size,Quantity,Description,Price,ImagePath")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Product
                                            orderby m.Catagory
                                            select m.Catagory;

            var catagories = new SelectList(await genreQuery.Distinct().ToListAsync());
            ViewBag.catagories = catagories;

            //return View();

            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Catagory,Size,Quantity,Description,Price,ImagePath")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id, bool nonue)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}
