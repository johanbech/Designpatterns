using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Originator
    {
        private string state;
        //public Originator()
        //{
        //    this.state = "Inital state";
        //}

        public string State
        {
            get { return state; }
            set { state = value; Console.WriteLine($"Current State : {state}"); }
        }

        public Memento GetMemento()
        {
           var mymem = new Memento();
            mymem.State = state;
            return mymem;
        }

        public void RevertToState(Memento previousMenmento)
        {
            Console.WriteLine("Restoring to previous State...");
            this.state = previousMenmento.State;
            Console.WriteLine($"Current State {state}");
        }
        

    }
}
