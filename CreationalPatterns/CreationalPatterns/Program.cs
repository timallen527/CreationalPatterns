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
            RunAbstractFactory();
            Console.Read();
        }

        private static void RunFactoryMethod()
        {
            Console.WriteLine(Environment.NewLine + "Factory Method");

            var factoryA = new ProductAFactory();
            var productA = factoryA.CreateProduct();
            Console.WriteLine(productA.title);

            var factoryB = new ProductBFactory();
            var productB = factoryB.CreateProduct();
            Console.WriteLine(productB.title);
        }

        private static void RunAbstractFactory()
        {
            Console.WriteLine(Environment.NewLine + "Abstract Factory Method");

            var packageFactoryA = new PackageFactory();
            var factoryA = new ProductAFactory();
            var productA = packageFactoryA.MakePackage(factoryA);
            Console.WriteLine(productA.title);

            var packageFactoryB = new PackageFactory();
            var factoryB = new ProductBFactory();
            var productB = packageFactoryB.MakePackage(factoryB);
            Console.WriteLine(productB.title);
        }
    }
}
