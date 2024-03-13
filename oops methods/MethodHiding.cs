using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding 
{
     class parent 
    {
        public void display() {
            Console.WriteLine("parent hiding method");
        }

    }
    class child : parent 
    {
        public new void display()
        {
            Console.WriteLine("child hiding method");
        }
    }
}
