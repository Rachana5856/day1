using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Implemetation
{
    abstract class Shape
        {
            // abstract method
            public abstract int area();
        }

        class Square : Shape
        {
            // private data member
            private int side;

            // method of  square class
            public Square(int x = 0)
            {
                side = x;
            }
            // overriding of the abstract method of Shape
            // class using the override keyword
            public override int area()
            {
                Console.Write("Area of Square: ");
                return (side * side);
            }



        }


    }

    

