using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_methods
{
     interface Father 
    {
        public void car()
        {
            Console.WriteLine("Father Car");
        }
    }
    interface Mother
    {
        public void car();
        
    }
    class Child : Father,Mother
    {
        public void car()
        {
            Console.WriteLine("renewal");
        }
    }
}
