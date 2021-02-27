using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindService.Controllers
{
    public class Product // Продукты
        
    {   
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ManufacturerId { get; set; }
    }
}
