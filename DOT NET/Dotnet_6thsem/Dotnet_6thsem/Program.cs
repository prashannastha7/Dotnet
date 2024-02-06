using System;

namespace Dotnet_6thsem
{
     class Program
    {
        static void Main(string[] args)
        {
            //creating object of box
            //when obj is created constructor is called
            Box b1 = new Box();// default constructor
            b1.calcArea();
            Box b2 = new Box(10,25,30);
            b2.calcArea();
            
            //For PropertiesDemo
            Console.WriteLine("example on properties");
            Rectangle r1 = new Rectangle();
            //calling set of length and breadth
            r1.Length = 10;
            r1.Breadth = 20;
            //calling get of length and breadth
            Console.WriteLine("Length is " + r1.Length);
            Console.WriteLine("Breadth is " + r1.Breadth);
            int area = r1.Length * r1.Breadth;
            Console.WriteLine("Area is " + area);

            Console.ReadKey();// to hold screen
        }
    }
}
