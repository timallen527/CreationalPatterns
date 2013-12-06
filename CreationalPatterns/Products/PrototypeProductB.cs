using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class PrototypeProductB : IPrototypeProduct
    {
        public String Title { get; set; }

        public PrototypeProductB()
        {
            Title = "Prototype Product B";
        }

        public IPrototypeProduct Clone()
        {
            return this.MemberwiseClone() as IPrototypeProduct;
        }
    }
}
