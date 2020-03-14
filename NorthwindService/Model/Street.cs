using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindService
{
    public class Street // Улица
    {
        public int StreetId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Custome> Customes { get; set; }
        public virtual ICollection<Manufacturer> Manufacturers { get; set; }
        public Street()
        {
            Customes = new List<Custome>();
            Manufacturers = new List<Manufacturer>();
        }
    }
}
