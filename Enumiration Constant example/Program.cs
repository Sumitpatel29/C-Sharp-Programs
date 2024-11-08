using System;

namespace Enumiration_Constant_example
{
    class Program{
         enum Days{sun,mon,tue,wed,thu,fri,sat}; //global declaration
        static void Main(string[] args)
        {
            int weekdays_start=(int) Days.mon;
            int weekdays_end=(int) Days.sat;
            Console.WriteLine("Value of Friday: "+ Days.fri); //output:- Value of Friday: fri
            Console.WriteLine("Monday:{0}",weekdays_start); //output:- Monday:1
            Console.WriteLine("Saturday:{0}",weekdays_end); //output:- Saturday:6
        }
    }
}
