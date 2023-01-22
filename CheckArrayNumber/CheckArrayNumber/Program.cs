using System;

namespace CheckArrayNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 0, 17, 26, 34, 68, 223, 15 };
            int[] value = {  5 };

            Console.WriteLine(CheckArrayNumber(numbers,value));      

          

        }

      
        static bool CheckArrayNumber(int[] numbers, int[] value)
            
        {
            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = 0; j < value.Length; j++)
                {
                    if (numbers[i] == value[j]) 
                    {
                        return true;
                    }
                }


            }  
            return false;



        }


















    }
}
