
namespace Dotnet_6thsem
{
    class Rectangle //class name can be any 
    {
        //properties is used to initialize instance variable and return value of instance variable
        //same like getter and setter method. contructor return this don'y return 
        private int length;
        private int breadth;
        //using properties
        public int Length
        {
            get { return length; }
            set { this.length = value; }
        }
        public int Breadth
        {
            get { return breadth; }
            set { this.breadth = value; }
        }
    }
}
