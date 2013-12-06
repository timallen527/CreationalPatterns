using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class Product : IProduct
    {
        public String title { get; set; }

        public Product()
        {
            title = "Sample Product";
        }
    }
}
