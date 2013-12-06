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
            RunPrototype();
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

        private static void RunPrototype()
        {
            Console.WriteLine(Environment.NewLine + "Prototypes");

            var prototypeA = new PrototypeProductA();
            Console.WriteLine(prototypeA.Title);

            var prototypeAClone = prototypeA.Clone();
            Console.WriteLine(prototypeA.Title);

            var prototypeB = new PrototypeProductB();
            Console.WriteLine(prototypeB.Title);

            var prototypeBClone = prototypeB.Clone();
            Console.WriteLine(prototypeB.Title);
        }
    }
}
