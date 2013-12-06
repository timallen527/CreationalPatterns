using Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ProductBFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}
