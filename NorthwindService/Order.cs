using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindService
{
    public class Order // Заказы
    {
            public int OrderId { get; set; }
            
            public int ProductId { get; set; }
            
            public virtual Manufacturer Manufacturer { get; set; }
            public int Quantity { get; set; }

            public int CustomeId { get; set; }
            
            public Custome Custome { get; set; }

            public DateTime ReleaseDate { get; set; }
           
            public double Payment { get; set; }

        
    }
}
