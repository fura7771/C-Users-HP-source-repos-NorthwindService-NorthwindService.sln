using NorthwindService.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindService
{
    public class Manufacturer // Производитель
    {
        public int ManufacturerId { get; set; }
        public string NameCompany { get; set; }
        public int PoductId { get; set; }
        public Product Product { get; set; }
        public int CityId { get; set; }
        public int StreetId { get; set; }
        public virtual Street Street { get; set; }
        public double NomerDom { get; set; }
        public double Nomerkvart { get; set; }
        public string Detector { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Manufacturer()
        {
            Products = new List<Product>();
        }
    }

}
