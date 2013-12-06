using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Products
{
    public class ProductA : IProduct
    {
        public String title { get; set; }

        public ProductA()
        {
            title = "Product A";
        }
    }
}
