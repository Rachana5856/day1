using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Implemetation
{
    class Program
    {

        static void Main(string[] args)
        {
            //Encapsulation
            Encap obj = new Encap();
            obj.Name = "Ankita";
            obj.Age = 21;
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
            
            // Inheritence 
            GeeksforGeeks g = new GeeksforGeeks();  
            g.readers("Kirti", "C#");
            

            //Abstraction
            // creating reference of Shape class
            // which refer to Square class instance
            Shape sh = new Square(4);
            // calling the method
            double result = sh.area();
            Console.Write("{0}", result);
            

            //Method Overloading 
            Polymol dataClass = new Polymol();
            { 
            int add2 = dataClass.Add(45, 34, 67);
            int add1 = dataClass.Add(23, 34);
            Console.WriteLine();
            }


            //Method OverRiding
            PolyMethor ol = new PolyMethor();
            ol.show();
            ol = new derived();
            ol.show();
            

            //Shadowing
            Child child = new Child();
            Console.WriteLine(child.Display());

            //Multiple Inheritance not supported as there are various method by same name
            MultipleInherit3 m = new MultipleInherit3();
            
            //Interface 
            multipleInheritence multi = new multipleInheritence();
            inter1 i1 = multi;
            inter2 i2 = multi;

            i1.Display1();
            i2.Display1();


            //Assignment operators--------------------------------------------
            int num1, num2;

            num1 = 10;
            num2 = 5;

            num1 += num2; // same as num1=num1+num2
            Console.WriteLine("Add = {0}", num1);

            num1 -= num2; // same as num1=num1-num2
            Console.WriteLine("Subtraction = {0}", num1);

            num1 *= num2; // same as num1=num1*num2
            Console.WriteLine("Multiplication={0}", num1);

            num1 %= num2; // same as num1=num1%num2
            Console.WriteLine("Modulus = {0}", num1);

            //for loop
            int n = 5, sum = 0;

            for (int i = 1; i <= n; i++)
            {
                // sum = sum + i;
                sum += i;
            }
            
            Console.WriteLine("Sum of first {0} natural numbers = {1}", n, sum);


            //while loop-------------------------------------------------
            int j = 1, add = 0;

            while (j <= 5)
            {
                add += j;
                j++;
            }
            Console.WriteLine("Sum = {0}", sum);

            //do while loop---------------------------------------------------

            int k = 1, l = 5, product;

            do
            {
                product = l * k;
                Console.WriteLine("{0} * {1} = {2}", n, k, product);
                k++;
            } while (k <= 10);

            Console.ReadLine();
            }

        

        
      
        
        

            
        }
    }
