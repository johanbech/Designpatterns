using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class AbstractDecorator :Component
    {
        protected Component com;

        public void SetTheComponent(Component c)
        {
            com = c;
        }

        public override void makeHouse()
        {
            if (com != null)
            {
                com.makeHouse();
            }
        }
    }
}
