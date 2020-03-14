using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindService
{
    public class Custome // Клиенты 
    {
        public int CustomeId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Ochestovo { get; set; }
        public int StreetId { get; set; }
        public virtual Street Street { get; set; }
        public double NomerDom { get; set; }
        public double Nomerkvart { get; set; }
        public string Tell { get; set; }
        public string Email { get; set; }
    }
}
