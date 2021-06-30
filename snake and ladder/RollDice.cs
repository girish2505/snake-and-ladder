using System;
using System.Collections.Generic;
using System.Text;

namespace snake_and_ladder
{
    class RollDice
    {
        public static int Start_Position = 0;
        public void StartGame()
        {
           //Console.WriteLine("Player position start with : "+Start_Position);

            int roll;
            //creating random class
            Random rand = new Random();

            roll = rand.Next(1, 7);

            Console.WriteLine("Player throws " + roll);
        }
    }
}
