using System;

namespace reverse_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="sumit";
            string rev="";
            //
            for(int i=0;i<str.Length;i++)
            {
                Console.Write(str[i]+" ");
            }
            int j=str.Length-1; //store the last index of the string in j
            while(j>=0) //continue the loop till j becomes 0
            {
                rev=rev+str[j]; //do string concatenation to reverse the string
                j--; //decrease the value of j by 1 in each iteration
            }
            Console.WriteLine("Reverse is: "+rev);
            // Console.WriteLine(str.Length);
        }
    }
}
