using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class ConcreteDecoratorEx2 : AbstractDecorator
    {
        public override void makeHouse()
        {
            base.makeHouse();
            Console.WriteLine("*** Using a decorator ***");
            PaintTheHouse();
        }

        private void PaintTheHouse()
        {
            Console.WriteLine("Now I am painting the house.");
        }
    }
}
