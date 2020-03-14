using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindService
{ 
    public class Position_Order // позиция заказа
    {
            public int OrderId { get; set; }
            public Order Order { get; set; }
            public int ProductId { get; set; }
            public virtual Manufacturer Manufacturer { get; set; }
            public int Quantity { get; set; }
        
    }
}
