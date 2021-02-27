using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindService.Controllers
{
    [Route("api/[controller]")]
    public class ProductController: Controller
    {
        ProductContext db;
    public ProductController(ProductContext context)
        {
            db = context;
            if (!db.Products.Any())
            {
                db.Products.Add(new Product { Name = "товар" });
                db.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            var Product = db.Products.ToArray();
            return Product;
        }
    }
}
