using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;

namespace FactoryMethod
{
    public interface IProductFactory
    {
        IProduct CreateProduct();
    }
}
