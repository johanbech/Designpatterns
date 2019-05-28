using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class ConcreteComponent : Component
    {
        public override void makeHouse()
        {
            Console.WriteLine("Original House is Complete. It is closed for modification.");
        }
    }
}
