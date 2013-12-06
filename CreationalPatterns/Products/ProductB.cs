using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Products
{
    public class ProductB : IProduct
    {
        public String title { get; set; }

        public ProductB()
        {
            title = "Product B";
        }
    }
}
