using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers
{
    public class ProductController : Controller
    {
        private readonly CoffeeShopContext _context;

        public ProductController(CoffeeShopContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public ActionResult Detail(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }
    }
}
