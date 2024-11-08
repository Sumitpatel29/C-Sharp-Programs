using System;

namespace switch_case__example__pending
{
    class Program
    {
        static void Main(string[] args)
        {
            int avg=28;
            switch(avg/10)
            {
                case 10:
                case 9:
                case 8:
                case 7:
                case 6:
                Console.WriteLine("1st didvision");
                break;
                case 5: Console.WriteLine("2nd division");
                break;
                case 4: Console.WriteLine("3rd division");
                break;
                default: Console.WriteLine("fail");
                break;
                
            }
            
        }
    }
}
