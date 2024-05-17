using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class RecursionTasks
    {
        public void Run() 
        {
            //task 1

            static string RecursionIsPalindrome(string wordToCheck)
            {

                if (wordToCheck.Length < 2) //дошли до середины
                {
                    return "YES";
                }
                else if (wordToCheck[0] != wordToCheck[wordToCheck.Length - 1]) // видим, что не совпадает
                {
                    return "NO";
                }
                //чек крайних символов

                //продолжаем двигаться минус крайние символы

                return RecursionIsPalindrome(wordToCheck.Substring(1, wordToCheck.Length - 2));
            }
            //Console.WriteLine(RecursionIsPalindrome("kayak"));


            //task 2

            static string RecursionNumbersOutput(int numberToRecurse, string output = "")
            {

                output += $"{numberToRecurse}";

                if (numberToRecurse == 1)
                {
                    return output;
                }
                else
                {
                    var result = output + RecursionNumbersOutput(--numberToRecurse);

                    return result;
                }
            }

            //Console.WriteLine(RecursionNumbersOutput(10));
        }
    }
}
