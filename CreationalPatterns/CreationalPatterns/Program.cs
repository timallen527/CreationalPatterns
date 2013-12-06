using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;
using AbstractFactory;

namespace CreationalPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunFactoryMethod();
            RunAbstractFactoryMethod();
            Console.Read();
        }

        private static void RunFactoryMethod()
        {
            Console.WriteLine(Environment.NewLine + "Factory Method");

            IProductFactory factoryA = new ProductAFactory();
            IProduct productA = factoryA.CreateProduct();
            Console.WriteLine(productA.title);

            IProductFactory factoryB = new ProductBFactory();
            IProduct productB = factoryB.CreateProduct();
            Console.WriteLine(productB.title);
        }

        private static void RunAbstractFactoryMethod()
        {
            Console.WriteLine(Environment.NewLine + "Abstract Factory Method");

            IPackageFactory packageFactoryA = new PackageFactory();
            IProductFactory factoryA = new ProductAFactory();
            IProduct productA = packageFactoryA.MakePackage(factoryA);
            Console.WriteLine(productA.title);

            IPackageFactory packageFactoryB = new PackageFactory();
            IProductFactory factoryB = new ProductBFactory();
            IProduct productB = packageFactoryB.MakePackage(factoryB);
            Console.WriteLine(productB.title);
        }
    }
}
