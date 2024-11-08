using System;

namespace if_else_ladder__example_
{
    class Program
    {
        static void Main(string[] args)
        {
            int avg=50; 
            if(avg>=60)
            {
            Console.WriteLine("1st division");
            }
            else if(avg>=50)
            {
                Console.WriteLine("2nd division");
            }
            else if(avg>=40)
            {
                Console.WriteLine("3rd division");
            }
            else
            {
                Console.WriteLine("Fail !!");
            }
        }
    }
}
