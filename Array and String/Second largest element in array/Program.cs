using System;

namespace Second_largest_element_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int large1=0;int large2=0;
            int[] x={10,5,90,23,145,76,45,25};
            Console.WriteLine("The array elements are: ");
            for(int i=0;i<x.Length;i++)
            {
                Console.Write(x[i]+" ");
            }
            Console.WriteLine();
            for(int i=0;i<x.Length;i++)
            {
                if(x[i]>large1)
                {
                    large1=x[i];
                }
                for(int j=0;j<x.Length;j++)
                {
                    if(x[i]>large2 && large1!=x[i])
                    {
                    large2=x[i];
                    }
                }
            }
            Console.WriteLine("1st largest is "+ large1+" and 2nd largest is "+large2);
        }
    }
}
