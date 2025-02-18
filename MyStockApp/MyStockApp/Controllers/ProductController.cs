using Microsoft.AspNetCore.Mvc;
using MyStockApp.Models;

namespace MyStockApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly MyStockDbContext context;
        public ProductController(MyStockDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var model = context.Products.ToList();
            return View(model);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = context.Products.FirstOrDefault(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
