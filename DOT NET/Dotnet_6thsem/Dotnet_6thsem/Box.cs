using System;

namespace Dotnet_6thsem
{
    class Box
    {
        //instance variable: class data
        private int length;
        private int breath;
        private int height;
        //contructor: used to initialize instance variable
        //default constructor: w/o parameter

        public Box()
        {
            length = 0;
            breath = 0; 
            height = 0;
        }
        //parameterized constructor
        public Box(int length, int breath, int height)
        {
            this.length = length;
            this.breath = breath;
            this.height = height;
        }
        //method: used to provide some services
        //method w/o returning value
        public void calcArea()
        {
            int area = this.length * this.breath * this.height;
            Console.WriteLine("Area is " + area);
        }
    }
}
