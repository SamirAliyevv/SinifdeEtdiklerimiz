using System;

namespace FindNumberList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 8, 98, 0, 23, 12, 222, 555 };
            
            Console.WriteLine(FindNumberList(numbers,222));
            
        }
    
       static bool FindNumberList(int[] arr,int number)
       {
            for (int i = 0; i < arr.Length; i++)
            {
                if (number == arr[i]) 
                {
                    return true;
                }

            }
            return false;
       }    
    
    }
}
