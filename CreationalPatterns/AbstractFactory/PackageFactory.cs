using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;
using FactoryMethod;

namespace AbstractFactory
{
    public class PackageFactory : IPackageFactory
    {
        public IProduct MakePackage(IProductFactory productFactory)
        {
            return productFactory.CreateProduct();
        }
    }
}
