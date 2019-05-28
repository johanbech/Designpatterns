using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Decorator pattern Demo***\n");
            ConcreteComponent cc = new ConcreteComponent();

            ConcreteDecoratorEx1 decoratorEx1 = new ConcreteDecoratorEx1();
            decoratorEx1.SetTheComponent(cc);
            decoratorEx1.makeHouse();

            ConcreteDecoratorEx2 decoratorEx2 = new ConcreteDecoratorEx2();
            decoratorEx2.SetTheComponent(decoratorEx1);
            decoratorEx2.makeHouse();

            Console.ReadKey();
        }
    }
}
