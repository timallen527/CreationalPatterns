using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;

namespace FactoryMethod
{
    public class ProductAFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}
