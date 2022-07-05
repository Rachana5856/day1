using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Implemetation
{
    class PolyMethor
    {
        public virtual void show()
        {
            Console.WriteLine("Base class");
        }

    }
        class derived : PolyMethor
        {

            // overriding
            public override void show()
            {
                Console.WriteLine("Derived class");
            }
        }
    
}
