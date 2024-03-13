using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_methods
{
     class PolyMethodOverloading
    {
         public void sum(int a)
        {
            Console.WriteLine("integer : {0}", a);
        }
        public void sum(int a,int b)
        {
            Console.WriteLine("integer :{0} ", a+b);
        }
        public void sum(int a,int b,int c) 
        {
            Console.WriteLine("integer : {0}", a+b+c);
        }


    }
     
    class Example : PolyMethodOverloading
    {
        public void sum(string a,string b)
        {
            Console.WriteLine(a + " " + b);
        }
    }
}
