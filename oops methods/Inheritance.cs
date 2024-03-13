using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_methods
{
    class Inheritance
    {
        public string name = "Goutham";
        public void add()
        {
            Console.WriteLine("Addition method");
            




        }
    }
    class B : Inheritance
    {
        public void sub()
        {
            Console.WriteLine("addition methode");



        }
    }
    class C : B {
        public void mult()
        {
            Console.WriteLine("it is multiplication");
        }
    }
}



