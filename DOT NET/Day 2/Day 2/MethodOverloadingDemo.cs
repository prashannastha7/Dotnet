﻿using System;

namespace Day_2
{

    //method overloading refers to two or more method having same name but diff number of parameter
    class Calculations
    {
        public void calc()
        {
            Console.WriteLine("This is default");
        }
        public void calc(int x, int y)
        {
            Console.WriteLine("Sum is " + (x + y));
        }
        //if no. of parameter are also same then their datatype should be diff
        public void calc(double x, double y)
        {
            Console.WriteLine("Difference is " + (x - y));
        }
        public int calc(int x, int y, int z)
        {
            return (x * y * z);
        }
        //method overriding is used to achieve static polymorphism look like same but different work
    }
}
