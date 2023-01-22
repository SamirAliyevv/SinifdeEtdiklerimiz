using System;

namespace CutStringIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CutStringIndex("Samir",3));

        }

      
                            
        static string CutStringIndex (string word,int index)
        {
            string NewStr = "";
            for (int i = 0; i < index; i++)
            {
                NewStr+= word[i];  


            }

            return NewStr;  

        }






    }
}
