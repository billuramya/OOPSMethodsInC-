using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_methods
{
    class Emcapsdemo
    {
        private string name{  get; set; }
        private int age{  get; set; }

        private void Emcapsdemo(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //static void Main()
        //{
        //    Emcapsdemo en = new Emcapsdemo();
        //    en.age = 5;
        //    en.name = "Goutham";
        //    Console.Write(en.age);
        //    Console.Write(en.name);
        //}

    }
}
