using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class StringTasks
    {
        public void Run() 
        {
            //task 1
            string myStr = "I have a 123 childChild and 234325 my chiLd has a 5435 child.";
            char[] toRemove = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            StringBuilder sb = new StringBuilder();

            foreach (char c in myStr)
            {
                // if c is a number
                var isNumber = CheckIfIsNumberTheEasierWay(c);
                if (!isNumber)
                {
                    sb.Append(c);
                }
            }

            bool CheckIfIsNumber(char c)
            {
                foreach (char c2 in toRemove)
                {
                    if (c == c2)
                    {
                        return true;
                    }
                }

                return false;
            }

            bool CheckIfIsNumberTheEasierWay(char c)
            {
                return c >= 48 && c <= 57;
            }

            sb.Replace("child", "children");

            Console.WriteLine(sb.ToString());
            Console.WriteLine("\n");


            //task 2
            string s1 = "Welcome";
            string s2 = "to";
            string s3 = "the";
            string s4 = "godel";
            string s5 = "team";
            string[] words = new string[] { s1, s2, s3, s4, s5 };
            string greeting = String.Join(" ", words);
            Console.WriteLine($"{greeting}.");
            Console.WriteLine("\n");


            //task 3
            string stringToSplit = "Godelteamwithsomeofexcersicesabcwanttomakeitbetter.";
            string splitPoint = "abc";
            int indexOfSplitPoint = stringToSplit.IndexOf(splitPoint);
            string part1 = stringToSplit.Substring(0, indexOfSplitPoint);
            string part2 = stringToSplit.Substring(indexOfSplitPoint + 3);
            Console.WriteLine(part1);
            Console.WriteLine(part2);
            Console.WriteLine("\n");

            //task 4
            string myString4 = "Bad day.";
            string substring1 = "Great";
            string substring2 = "!!!!!!";
            myString4 = myString4.Substring(3);
            myString4 = myString4.Insert(0, substring1);
            myString4 = myString4.Insert(9, substring2);
            myString4 = myString4.Replace("!.", "?.");
            Console.WriteLine(myString4);

        }
    }
}
