
using System;
using System.Net.Http.Headers;

namespace FindCharIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindCharIndex("Samir",'S'));
        }


        static int FindCharIndex(string word,char cr)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==cr)
                {

                    return i;   
                }


            }
            return -1; 
        }
        
    }
}
