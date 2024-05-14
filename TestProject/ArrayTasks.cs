using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class ArrayTasks
    {
        public void Run()
        {
            //task 1
            Console.WriteLine("Write your string.");
            string mySting = Console.ReadLine();
            Console.WriteLine("Write your char.");
            var mySymbol = Console.ReadLine();
            int charAmount = 0;
            foreach (var c in mySting)
            {
                if (mySymbol == $"{c}") charAmount++;
            }
            double entryPercentage = charAmount * 100 / mySting.Length;
            Console.WriteLine($"Entry percentage of {mySymbol} in the string is {entryPercentage}%.");
            Console.WriteLine("\n");

            //task 2
            string[] surnames = new string[] { "Peterson", "Brown", "Wilson", "Harris", "Robinson-walker" };
            int counter = 0;
            string winner = "";
            foreach (var s in surnames)
            {
                if (s.Length > counter)
                {
                    counter = s.Length;
                    winner = s;
                }

            }
            Console.WriteLine($"The longest surname is {winner}.");
            Console.WriteLine("\n");

            //task 3
            Console.WriteLine("Type down a sentence. I am going to count the number of words in it.");
            string mySentence = Console.ReadLine();
            string[] mySentenceList = mySentence.Split(new char[] { ' ' });
            Console.WriteLine(mySentenceList.Length);

            //task 4
            int[] myArray = new int[] { 2, 11, 65, 43, 1, 4, 15, 6, 72, 103, 13 };

            int[] evenArray = myArray
                                .Where(it => it % 2 == 0)
                                .OrderBy(it => it)
                                .ToArray();

            int[] oddArray = myArray
                                .Where(it => it % 2 != 0)
                                .OrderBy(it => it)
                                .ToArray();

            //task 7
            string[] words = new string[] { "abraacadaabra", "belLio", "whiite" };
            string[] updatedWords = new string[words.Length];

            for (var i = 0; i < words.Length; i++)
            {
                var originalWord = words[i];
                var singleLettersWord = "";

                for (int j = 0; j < originalWord.Length; j++)
                {
                    var currentChar = originalWord[j];

                    if (j == originalWord.Length - 1)
                    {
                        singleLettersWord += currentChar;
                    }
                    else if (currentChar != originalWord[j + 1])
                    {
                        singleLettersWord += currentChar;
                    }
                }

                updatedWords[i] = singleLettersWord;
            }



            foreach (var word in updatedWords)
                Console.WriteLine(word);
        }
    }
}
