using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;

namespace TestProject
{
    public class MathTasks
    {
        public void Run() 
        {
            /*Console.WriteLine("Hello. Type your word, please, so I could count characters in it:");
            string word = Console.ReadLine();
            Console.WriteLine($"Your word has {word.Length} charecters"); */


            //Console.WriteLine(87 / 9);
            //Console.WriteLine(3 + 11 * 6 % 4);
            var a = 5;
            var b = 7;
            //var squareA = Math.Pow(a, 2);
            //var squareB = Math.Pow(b, 2);
            //var c = Math.Sqrt(squareA + squareB);
            //Console.WriteLine(c);

            //double CalculateHypotenuse(double cat1, double cat2) //посчитать гипотенузу функцией
            //{
            //    double squareCat1 = Math.Pow(cat1, 2);
            //    double squareCat2 = Math.Pow(cat2, 2);
            //    double result = Math.Sqrt(squareCat1 + squareCat2);
            //    return result;
            //}
            //Console.WriteLine(CalculateHypotenuse(a, b));

            Console.WriteLine(a > b); //1 задача. не понимаю задачу (а что если равно?). и как будто числа не вводятся, а уже присвоены. странная задача

            Random rnd = new Random(); //2 задача
            int value2 = rnd.Next();
            Console.WriteLine(value2);
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            bool result2 = a2 > value2 && b2 > value2;
            Console.WriteLine(result2);
            Console.ReadKey();

            Console.WriteLine("Type 2 numbers. Let's check if their sum = 98");  //3 задача
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            bool result3 = (x3 + y3) == 98;
            Console.WriteLine($"Their sum equals 98: {result3}");

            Console.WriteLine("Type 3 numbers. Let's see if the sum of the 1st and 2nd is equal to the 3rd number");  //4 задача
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());
            int z4 = Convert.ToInt32(Console.ReadLine());
            if (x4 + y4 == z4)
            {
                Console.WriteLine("The sum of the 1st and 2nd is equal to the 3rd number");
            }

            Console.WriteLine("Type some string. I will let you know if it's longer than 13 characters");  //5 задача
            string myString5 = Console.ReadLine();
            if (myString5.Length > 13)
            {
                Console.WriteLine("Oh yeah it's longer than 13 wow");
            }
        }   
    }
}
