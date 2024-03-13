using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oops_methods
{
    abstract class AbstMethod 
    {
        public abstract void cal(double a);
    }
    class Squeare : AbstMethod
    {
        public override void cal(double a)
        {
            Console.WriteLine("area is squeare : "+ a*a);
        }

    }
    class cude:AbstMethod 
    {
        public override void cal(double a)
        {
            Console.WriteLine("area of cube: " + a * a * a);
                } 
    }
} 
 namespace AbstractExample
{
    abstract class students
    {
        protected int Sno;
        protected string name;
        public abstract void getDetails();
        public virtual void Display() {
            Console.WriteLine("sno is : {0}",this.Sno);
            Console.WriteLine("student name : {0}", this.name);
        }


    }
    class Pstudents : students {
        protected string Address;
        public override void getDetails()
        {
            Console.WriteLine("enter student sno");
            Sno=int.Parse(Console.ReadLine());
            Console.WriteLine("enter student name");
            name = Console.ReadLine();
            Console.WriteLine("enter student address");
            Address = Console.ReadLine();

        }
        public override void Display()
        {
            Console.WriteLine("sno is : {0}", Sno);
            Console.WriteLine("student name : {0}",name);
            Console.WriteLine("student address :{0}", Address);
        }

    }
}
