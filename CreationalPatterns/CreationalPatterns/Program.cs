using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunFactoryMethod();
            Console.Read();
        }

        private static void RunFactoryMethod()
        {
            IProductFactory factory = new ProductFactory();
            IProduct product = factory.CreateProduct();
            Console.WriteLine(product.title);
        }
    }
}
