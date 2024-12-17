using System;

namespace reverse__an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x={10,5,90,23,145,76,45,25};
            Console.WriteLine("The array is: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]+" ");
            }
            Console.WriteLine();
            int i=0;
            int j=x.Length-1;
            int temp;
            while (i<j)
            {
                temp=x[i];
                x[i]=x[j];
                x[j]=temp;
                i++;j--;
            }
            Console.WriteLine("the reversed array is: ");
            for(int k=0;k<x.Length;k++)
            {
                Console.WriteLine(x[k]+" ");
            }
        }
    }
}
