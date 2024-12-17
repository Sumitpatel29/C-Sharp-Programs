using System;

namespace traverse_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size=Convert.ToInt32(Console.ReadLine());  //take size as input from user
            int[] x = new int[size];            //specify the size and create an array of specified size
            Console.WriteLine("Enter elements of array: ");

            //create a for loop to accept the elements of the array
            for(int i=0;i<size;i++)
            {
                x[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The array elements are: ");

            //it will print the array elements
            for(int i=0;i<x.Length;i++)
            {
                Console.Write(x[i]+" ");
            }
        }
    }
}
