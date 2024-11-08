using System;
using System.Net.NetworkInformation;

namespace area_of_circle__using_const_
{
    class Program
    {
           const double PI=3.14159;
        static void Main(string[] args)
        {
         double radius=0;
         Console.WriteLine("Enter the radius of the circle");
         radius=Convert.ToDouble(Console.ReadLine()); //to convert string to double
         double area=PI*radius*radius;          //formula to find area of circle
         Console.WriteLine("Radius of circle is "+radius+" and area is "+ area);
        // Console.WriteLine($"Radius={radius},Area={area}");   //2nd style of printing a value
        // Console.WriteLine("radius:{0}, area:{1}",radius,area);  //3rd style of printing a value
        }
    }
}
