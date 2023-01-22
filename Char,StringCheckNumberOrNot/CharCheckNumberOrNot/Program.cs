using System;

namespace CharCheckNumberOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CharCheckNum(1));


        }






        static bool CharCheckNum(char cr)
        {

            bool reqemdir=true;
            bool reqemdeyil = false;
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==cr)
                {
                    return reqemdir;
                }


            }
             return reqemdeyil;



        }


        static bool StringCheckNumber (string word)
        {
            for (int i = 0; i < word.Length; i++)
            {

                if (CharCheckNum(word[i]))
                {


                    return true;    
                }


            }

            return false;
        } 





    }


}
