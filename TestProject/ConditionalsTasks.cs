using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class ConditionalsTasks
    {
        public void Run()
        {
            // task 1.1
            Console.WriteLine("Let's check if your number even or odd.");
            int intInput11 = Convert.ToInt32(Console.ReadLine());
            if (intInput11 % 2 == 0)
                Console.WriteLine("Even");
            else if (intInput11 % 2 != 0)
                Console.WriteLine("Odd");
            else //who knows how it is possible if we get numbers, but well, it is in the task discription
                Console.WriteLine("Incorrect value");
            Console.WriteLine("\n");

            //task 1.2
            Console.WriteLine("Type in month number.");
            int intInput12 = Convert.ToInt32(Console.ReadLine());
            string DoOperation(int op) => op switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => " "
            };
            Console.WriteLine(DoOperation(intInput12));
            Console.WriteLine("\n");

            //task 1.3
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //task 1.4
            Console.WriteLine("Type in your input so I could check, if it contains 'test' in it.");
            string stringInput14 = Console.ReadLine();
            string subString14 = "test";
            if (stringInput14.IndexOf(subString14) >= 0)
                Console.WriteLine("Your input contains 'test'. ");
            else
                Console.WriteLine("I could not find 'test' in your input.");
            Console.WriteLine("\n");

            //task 1.6
            Console.WriteLine("Fill in your number. Let's see if it is divisible by 8.");
            int intInput16 = Convert.ToInt32(Console.ReadLine());
            bool result16 = intInput16 % 8 == 0 ? true : false;
            Console.WriteLine($"Divisible by 8 without a remainder: {result16}");
            Console.WriteLine("\n");
        }
    }

}
