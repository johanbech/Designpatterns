using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class ConcreteDecoratorEx1 : AbstractDecorator
    {
        public override void makeHouse()
        {
            base.makeHouse();
            Console.WriteLine("*** Using a decorator ***");
            AddFloor();
        }

        private void AddFloor()
        {
            Console.WriteLine("I am making an additional floor on top of it.");
        }
    }
}
