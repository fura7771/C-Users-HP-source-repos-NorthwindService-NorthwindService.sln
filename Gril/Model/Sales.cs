using System;
using System.Collections.Generic;
using System.Text;

namespace Gril.Model
{
    class Sales
    { 
        public int SalesId { get; set; }
        public int NomerOrder { get; set; }
        public DateTime dateTime { get; set; }
        public int ProductId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int EmployeesId { get; set; }
        public Employees Employees { get; set; }
    }
}
