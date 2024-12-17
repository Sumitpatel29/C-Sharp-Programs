using System;

namespace Largest_element_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int large=0;
            Console.WriteLine("Enter size of an array: ");  //define size of array
            int size=Convert.ToInt32(Console.ReadLine());
            int[] x=new int[size];
            Console.WriteLine("Enter elements of array: "); //accept elements of array
            for(int i=0;i<size;i++)
            {
                x[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array elements are:");   //print elements of array
            for (int i = 0; i < size; i++)
            {
                Console.Write(x[i]+" ");
            }
            Console.WriteLine();
            //traverse the array and find the largest element
            for(int i=0;i<x.Length;i++)
            {
                if(x[i]>large)
                {
                    large=x[i];   
                }
            }
            Console.WriteLine("Largest element is: "+large);
        }
    }
}
