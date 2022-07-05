using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Implemetation
{
    public class Shadow
    {
            public string Display()
            {
                return "Parent Class!";
            }
       
    }
        public class Child : Shadow
        {
            public new string Display()
            {
                return "Child Class!";
            }
        }
    }
