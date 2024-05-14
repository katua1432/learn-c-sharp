using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class CyclesTasks
    {
        public void Run()
        {
            //task 1
            Console.WriteLine("Numbers from 1 to 50:");
            for (int i = 1; i <= 50; i++)
                Console.WriteLine(i);

            //task 2
            int myNumber = 0;
            for (int i = 1; i <= 10; i++)
                myNumber += i;
            Console.WriteLine($"The sum of the first 10 natural numbers: {myNumber}");

            //taks 3
            Console.WriteLine("n = 1000. How may times shoud we devide it by 2, until it gets less than 50?");
            int n = 1000;
            int interactionCounter = 0;
            while (n >= 50)
            {
                n = n / 2;
                interactionCounter++;
            }
            Console.WriteLine($" n = {n} now. We devided it {interactionCounter} times.");

            //task 4
            Console.WriteLine("Write a number.");
            int myInput = Convert.ToInt32(Console.ReadLine());
            string result = "";
            for (int i = 0; i < myInput; i++)
            {
                result += Convert.ToString(i + 1);
                Console.WriteLine(result);
            }


            //task 5
            Random random = new Random();
            Console.WriteLine("I've picked up a number from 0 to 100. Can you guess it?");
            int randomToGuess = random.Next(0, 101);
            bool playWill = true;

            do
            {
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if (randomToGuess > userGuess)
                {
                    Console.WriteLine("More.");
                }
                else if (randomToGuess < userGuess)
                {
                    Console.WriteLine("Less.");
                }
                else
                {
                    Console.WriteLine("Correct! Would you like yo try again? Type YES/NO");
                    var userAnswer = Console.ReadLine();
                    if (userAnswer.ToLower() == "yes")
                    {
                        randomToGuess = random.Next(0, 101);
                    }
                    else
                    {
                        playWill = false;
                    }
                }
            }
            while (playWill);

        }
    }
}
