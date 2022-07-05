using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Implemetation
{
    interface inter1
    {
         void Display1();        
    }

    interface inter2
    {
         void Display1();
     }
    public class multipleInheritence: inter1,inter2//Implementation of Multiple Inheritance

    {
                 void inter1.Display1()
            {
                Console.WriteLine("First Inheritance");
            }
                 void inter2.Display1()
            {
                Console.WriteLine("Second Inheritance");
            }
     }
}
