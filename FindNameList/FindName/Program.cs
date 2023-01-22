using System;

namespace FindName
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "Saleh","Samir","Namiq","Ceyhun" };
            Console.WriteLine(FindName(names, "Ceyhun"));


        }
        static bool FindName(string[] arr, string value)
        { 
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value) 
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
