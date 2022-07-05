using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Implemetation
{
    class MultipleInherit
    { 
       public void Display()
        {
            Console.WriteLine("First level");
        }
    }
    class MultipleInherit2
    {
        public void Display()
        {
            Console.WriteLine("Second level");
        }
    }
    class MultipleInherit3 : MultipleInherit//Mutiple Inheritance not possible in this case
    {
        public void Display()
        {
            Console.WriteLine("Third level");
        }
    }
}

