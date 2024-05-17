using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class MethodsAndNugetTasks
    {
        public void Run()
        {
            ////task 1
            //var myXmlText = "<root> <title>users storage</title> <user id='1'> <name>Vasya</name> </user> <user id='2'> <name>Kolya</name> </user> </root>";

            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(myXmlText);
            //string json = JsonConvert.SerializeXmlNode(doc);
            //Console.WriteLine(json);

            //task 2

            static void SayVasya()
            {
                Console.WriteLine("My name is Vasya");
            }

            static void SayKolya()
            {
                Console.WriteLine("My name is Kolya");
            }

            //task 3
            static void SayName(string name)
            {
                Console.WriteLine($"My name is {name}.");
            }
            //SayName("Katya");
            //SayName("Misha");

            //task 4,5,6
            static void SayNameAndAge(string name, int age)
            {
                if (age == 1)
                {
                    Console.WriteLine($"My name is {name} and I'm 1 year old.");
                }
                else if (age == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine($"My name is {name} and I'm {age} years old.");
                }

            }
            //SayNameAndAge("Alex", 1);
            //SayNameAndAge("Marry", 22);
            //SayNameAndAge("test", 0);

            //taks 7



            static void SayPeopleAge(int age, params string[] people)
            {
                // StringBuilder
                string result = "We are ";
                for (int i = 0; i < people.Length; i++)
                {
                    var personToAdd = people[i];

                    bool isFirst = i == 0;
                    bool isLast = i == people.Length - 1;

                    if (!isFirst && !isLast)
                    {
                        result += ", ";
                    }

                    if (isLast)
                    {
                        result += " and ";
                    }

                    result += personToAdd;



                }
                Console.WriteLine($"{result}. And we are {age} years old.");
            }

            //SayPeopleAge(20, "Rob", "Marry", "Clare", "John");

            //task 8

            static string[] JoinArrays(string[] array1, string[] array2)
            {
                var totalLength = array1.Length + array2.Length;
                string[] result = new string[totalLength];

                for (int i = 0; i < array1.Length; i++)
                {
                    result[i] = array1[i];
                }
                for (int i = 0; i < array2.Length; i++)
                {
                    var scewedResultIndex = i + array1.Length;

                    result[scewedResultIndex] = array2[i];
                }

                return result;
            }

            //string[] myArray1 = new string[3] {"check", "if", "it"};
            //string[] myArray2 = new string[2] {"works", "!" };

            //string[] myArray3 = JoinArrays (myArray1, myArray2);
            //foreach (string i in myArray3)
            //    Console.WriteLine(i);

            //Task 9

            static bool CheckYourBet(int bet) =>
                new Random().Next(0, 10) == bet;

            static int MakeBet(string name, int bet)
            {
                if (bet < 0 || bet > 10)
                {
                    Console.WriteLine($"{name}'s bet is not in 0-10 range.");
                    return 0;
                }
                else
                {
                    int tryCounter = 0;
                    var guess = false;

                    while (!guess)
                    {
                        tryCounter++;
                        guess = CheckYourBet(bet);
                    }

                    Console.WriteLine($"{name} guessed the result on try #{tryCounter}");
                    return tryCounter;
                }
            }

            MakeBet("Masha", 2);

            static void PlayAllTogether(params string[] playersAndBets)
            {
                //int bestResult = 0;
                //string winner = "";
                //for (int i = 0; i < playersAndBets.Length; i++) 
                //{
                //    string player = playersAndBets[i];
                //    int indexOfSplitPoint = player.IndexOf(" - ");
                //    string name = player.Substring(0, indexOfSplitPoint);
                //    string stringBet = player.Substring(indexOfSplitPoint + 3);

                //    int intBet = Convert.ToInt32(stringBet);

                //    int amountOfTries = MakeBet(name, intBet);
                //    if (i == 0)
                //    {
                //        bestResult = amountOfTries;
                //        winner = name;
                //    }
                //    else if (amountOfTries < bestResult)
                //    {
                //        bestResult = amountOfTries;
                //        winner = name;
                //    }
                //}

                string newBestPlayer = string.Empty;
                int newBestResult = int.MaxValue;

                foreach (var playerAndBet in playersAndBets)
                {
                    var splitted = playerAndBet.Split('-');
                    var player = splitted[0].Trim();
                    var bet = Convert.ToInt32(splitted[1].Trim());

                    var amountOfTries = MakeBet(player, bet);

                    if (amountOfTries < newBestResult)
                    {
                        newBestResult = amountOfTries;
                        newBestPlayer = player;
                    }
                }

                //    Console.WriteLine($"{winner} wins with best result {bestResult}");
                Console.WriteLine($"New {newBestPlayer} wins with new best result {newBestResult}");
            }
            PlayAllTogether("Mike - 2", "Robert - 7", "Lora - 3");

        }
    }
}
