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

        public int State
        {
            get { return State; }
            set { State = value; Console.WriteLine($"Current State : {state}"); }
        }

        public Memento GetMemento()
        {
           var mymem = new Memento();
            mymem.State = state;
            return mymem;
        }

        

    }
}
