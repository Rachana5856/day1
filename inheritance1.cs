using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Implemetation
{
    public class inheritance1
    {
        public string name;
        public string subject;

        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Language is: " + subject);
        }
    }
    class GeeksforGeeks : inheritance1
    {

        // constructor of derived class
        public GeeksforGeeks()
        {
            Console.WriteLine("Hello");
        }
    }
    


}
   