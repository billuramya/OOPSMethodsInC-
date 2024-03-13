using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_methods
{
     class PolyMethodOverriding1
    {
        public virtual void display()
        {
            Console.WriteLine("Parent class Method");
        }
    }

    class PolyMethodOverloading2:PolyMethodOverriding1 
    {
        public override void display() 
        {
            Console.WriteLine("Child class method");
        }
    }
}
