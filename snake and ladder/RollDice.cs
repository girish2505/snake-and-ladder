using System;
using System.Collections.Generic;
using System.Text;

namespace snake_and_ladder
{
    class RollDice
    {
        public static int Start_Position = 0;
        public const int Not_Play = 1;
        public const int Snake = 2;
        public const int Ladder = 3;
        public void StartGame()
        {
            //Console.WriteLine("Player position start with : "+Start_Position);

            int roll, checkOption, playerPosition = Start_Position;

            //creating random class
            Random rand = new Random();

            roll = rand.Next(1, 7);

            checkOption = rand.Next(1, 4);

            //Console.WriteLine(checkOption);
            switch (checkOption)
            {
                case Not_Play:
                    break;
                case Snake:
                    playerPosition += roll;
                    break;
                case Ladder:
                    playerPosition = (playerPosition - roll) < 0 ? 0 : (playerPosition - roll);
                    break;
                default:
                    break;
            }
                    Console.WriteLine("Player throws " + roll);
                    Console.WriteLine("Player Position" + playerPosition);
        }
    }
}

