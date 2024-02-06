using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Method overloading---");
            Calculations c1 = new Calculations();
            //callinh first method
            c1.calc();
            c1.calc(50,50); //second method
            c1.calc(100.2,30.2); //third method
            int mul = c1.calc(40, 30, 2);// calls fourth method
            Console.WriteLine("Multiplication is " + mul);


            Console.Write("---example on single level inheritance---");
            //creating obj of sub class
            Teacher t1 = new Teacher();
            //using parent properties
            t1.setEmployee(1, "hari", "ktm", "IT");
            t1.displayEmployee();
            //using own properties
            t1.setTeacher("Networking", "50000");
            t1.displayTeacher();
            //creating obj of parent class (super class)
            Employee e1 = new Employee();
            e1.setEmployee(2, "sam", "pkr", "Management");
            e1.displayEmployee();
            //Employee cann't access to Teacher properties



            Console.Wirteline("----MultilevelInhertance---")
                //creating obj of grandchild (ElectricBike)
                ElectricBike eb = new ElectricBike();
                eb.Reg = 101; //value diyo set called huncha
                eb.Name = "niu";
                eb.Model = "new";
                //using parent property (Bike)
                eb.speed = "40";
                //using own property
                eb.Range = "50";
            Console.WriteLine("reg is +" eb.Reg); //get called
            Console.WriteLine("name is +" eb.Name); //get called
            Console.WriteLine("model is +" eb.Model); //get called
            Console.WriteLine("speed is +" eb.speed); //get called
            Console.WriteLine("range is +" eb.Range); //get called

            //creating object of Bike
            Bike bi = new Bike();
            //using TwoWheeler property
            bi.Reg = 102;
            bi.Name = "pulsar";
            bi.Model = "old";
            bi.speed = "200"; //own property
            //bi.Rnage = "40"; cannot access
            Console.Writeline("reg is bike " + bi.Reg);
            Console.Writeline("name of bike " + bi.Name);
            Console.Writeline("model of bike " + bi.Model);
            Console.Writeline("speed of bike " + bi.Speed);



            Conosle.Writeline("");
            Conosle.Writeline("Base key");
            Solution new =


            Console.ReadKey(); //to hold screen
        }
    }
}
