using System;
using System.Collections.Generic;
using System.Text;

namespace snake_and_ladder
{
    class RollDice
    {
        public const int Start_Position = 0;
        public const int Not_Play = 1;
        public const int Snake = 2;
        public const int Ladder = 3;
        public void StartGame()
        {
            //Console.WriteLine("Player position start with : "+Start_Position);

            int roll, checkOption, playerPosition = Start_Position;
            int finalPosition = 100;
            int countRoll = 1;

            //creating random class
            Random rand = new Random();
            
            while (playerPosition < finalPosition)
            {
                roll = rand.Next(1, 7);
                checkOption = rand.Next(1, 4);
                Console.WriteLine("roll " + countRoll++);

                switch (checkOption)
                {
                    case Not_Play:
                        Console.WriteLine("Player position= " + playerPosition);
                        break;
                    case Snake:
                        playerPosition = (playerPosition - roll) < 0 ? 0 : (playerPosition - roll);
                        Console.WriteLine("Player position= " + playerPosition);
                        break;
                    case Ladder:
                        playerPosition += roll;
                        Console.WriteLine("Player position= " + playerPosition);
                        break;
                    default:
                        break;
                }
                playerPosition = playerPosition > finalPosition ? (playerPosition - roll) : playerPosition;
            }
            Console.WriteLine("Congratulations...._/\\_ " +finalPosition);
            Console.WriteLine("Total Dice Roll = " + --countRoll);
        }
    }
}

