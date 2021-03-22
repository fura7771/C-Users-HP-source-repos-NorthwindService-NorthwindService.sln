using System;
using System.Collections.Generic;
using System.Text;

namespace Gril
{
    class Product
    {
        //public static Product[] ItemsControl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

    }
}
