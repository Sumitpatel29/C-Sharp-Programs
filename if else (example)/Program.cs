using System;

namespace if_else__example_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=90;   //try to change this value to see the effect of if-else statement
            if (i > 100)
            {
            Console.WriteLine("Hello");
            Console.WriteLine("Hiii");
            }
            else    //this else block will execute, when the condition given in if will be false
            {
                Console.WriteLine("Bye");
                Console.WriteLine("Good Bye");
            }
        }
    }
}
