using System;

namespace Addition_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Value of 1st number: ");
            int x=Convert.ToInt32(Console.ReadLine()); //take input from user and convert it to integer
            Console.WriteLine("Enter the Value of 2nd number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;
            Console.WriteLine("Addition of 2 numbers is: "+z); //print the result
        }
    }
}
