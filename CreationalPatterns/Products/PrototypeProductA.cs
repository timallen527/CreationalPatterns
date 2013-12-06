using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class PrototypeProductA : IPrototypeProduct
    {
        public String Title { get; set; }

        public PrototypeProductA()
        {
            Title = "Prototype Product A";
        }

        public IPrototypeProduct Clone()
        {
            return this.MemberwiseClone() as IPrototypeProduct;
        }
    }
}
