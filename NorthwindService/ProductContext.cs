using NorthwindService.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindService
{
    public class ProductContext: DbContext
    {

        public DbSet<Product> Products { get; set; }


        public ProductContext(DbContextOption<ProductContext> option)
            
        {
            if (option is null)
            {
                throw new ArgumentNullException(nameof(option));
            }

            
        }

    }
}
