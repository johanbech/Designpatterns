using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Memento Pattern Demo***\n");
            //Originator is initialized with a state
            Originator originatorObject = new Originator();
            Memento mementoObject;
            originatorObject.State = "Opret state";
            mementoObject = originatorObject.GetMemento();
            //Making a new state
            originatorObject.State = "ny state";
            // Restore to the previous state
            originatorObject.RevertToState(mementoObject);
            // Wait for user's input
            Console.ReadKey();
        }
    }
}
