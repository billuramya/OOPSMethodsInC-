using AbstractExample;
using MethodHiding;
using oops_methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

class Program
{
    public static void Main(string[] args)
    {
        //Squeare squeare = new Squeare();
        //squeare.cal(2);
        //cude cude = new cude();
        //cude.cal(5);
        //Pstudents students = new Pstudents();
        
        //students.getDetails();
        //students.Display(); 
        //Child child = new Child();
        //child.car();
        //Father father = new Child();
        //father.car();
        //PolyMethodOverloading polyMethodOverloading = new PolyMethodOverloading();
        //polyMethodOverloading.sum(6);
        //polyMethodOverloading.sum(333,35);
        //polyMethodOverloading.sum(2,3,4);
        
        //Example example = new Example();
        //example.sum(4);
        //example.sum(5,5);
        //example.sum(6,5,6);
        //example.sum("ramya", "billu");

        //PolyMethods poly = new PolyMethods();
        //poly.display();
        PolyMethodOverloading2 polyMethodOverloading2 = new PolyMethodOverloading2();
        polyMethodOverloading2.display();
        child c = new child();
        c.display();

        

    }
}

