using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApplication
{
    class Rectangle
    {
        double length, breadth;

        public void GetInput()
        {
            Console.Write("Enter Length:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Breadth:");
            breadth = Convert.ToInt32(Console.ReadLine());
        }
        public double RectArea()
        {
            return length * breadth;
        }
        public void display()
        {
            Console.WriteLine($"Length:{length}\nBreadth:{breadth}");
            Console.WriteLine($"Area is: {RectArea()}");
        }
    }
}
