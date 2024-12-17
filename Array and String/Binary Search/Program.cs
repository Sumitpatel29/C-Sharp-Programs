using System;

namespace Binary_Search
{
    class Program
    {
        static int[] UserInput()
        {
            Console.WriteLine("Enter array size: ");
            int size=Convert.ToInt32(Console.ReadLine());
            int [] arr = new int[size];
            //accept array elements
            Console.WriteLine("Enter the array elements: ");
            for (int i=0;i<size;i++)
            {
               arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            //print array elements
            Console.WriteLine("The array elements are: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i]+" ");
            }
                return arr;
        }
        static int Binary_Search(int key,int[] arr)
        { 
            int start=0,end=arr.Length-1, mid=0;
            while(end > start)
            {
                mid= (end+start)/2;
                //check if key is present at middle
                if(arr[mid]==key)
                {
                    return mid; //index of key
                }
                //if key is smaller, ignore right half
                else if(arr[mid]>key)
                {
                    end=mid-1;
                }
                //if key is greater, ignore left half
                else 
                {
                    start=mid+1;
                }
            }
            return -1;  //incase the key element is not present in the array
        }
        static void Main(String[] args)
        {
            int[] arr=UserInput();
            Console.WriteLine("\nEnter Key element to Search: ");
            int key=Convert.ToInt32(Console.ReadLine());
            int result=Binary_Search(key,arr);
            Console.WriteLine(result);
        }
    }
}
