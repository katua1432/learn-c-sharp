using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class ApplesExample
    {
        public void Run()
        {
            // Masha & Sashs
            // Human
            var masha = new Human("Masha", 9);

            var sasha = new Human("Sasha", 11);

            //masha.TellApplesAmount();
            //sasha.TellApplesAmount();

            //masha.EatApple();
            //masha.EatApple();
            //masha.EatApple();

            //sasha.EatApple();
            //sasha.EatApple();
            //sasha.EatApple();
            //sasha.EatApple();

            //masha.apples = 12321;
            //sasha.apples = 321221;

            masha.TellApplesAmount();
            sasha.TellApplesAmount();

            masha.GiveApple(sasha);

            masha.TellApplesAmount();
            sasha.TellApplesAmount();

        }
    }
}
