using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Human
    {
        // Name
        private string Name;
        // Apples
        private int Apples;

        public Human(string name, int apples)
        {
            Name = name;
            Apples = apples;
        }
        // Give apple
        public void GiveApple(Human to)
        {
            Apples--;
            to.GetApple();
            Console.WriteLine($"{Name}: I've given an apple");
        }
        // Eat apple
        public void EatApple()
        {
            Apples--;
            Console.WriteLine($"{Name}: Yummy");
        }
        // Get apple
        public void GetApple()
        {
            Apples++;
            Console.WriteLine($"{Name}: Wow! I have one more apple");
        }

        // Tell how many apples they have
        public void TellApplesAmount()
        {
            Console.WriteLine($"{Name}: I have {Apples} apples!");
        }
    }
}
