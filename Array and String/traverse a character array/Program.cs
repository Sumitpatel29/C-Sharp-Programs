using System;

namespace traverse_a_character_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int size=Convert.ToInt32(Console.ReadLine());
            char[] ch = new char[size];
            Console.WriteLine("Enter the elements of array: ");
            //creating array of specified size
            for(int i=0;i<size;i++)
            {
                ch[i]=Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Array elements are: ");
            //print the array elements
            for(int i=0;i<ch.Length;i++)
            {
                Console.Write(ch[i]+" ");
            }
        }
    }
}
