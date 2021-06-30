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
        public static int playerOnePosition = Start_Position;
        public static int playerTwoPosition = Start_Position;
        public static int countRoll = 0;
        public static int countRollP1 = 0;
        public static int countRollP2 = 0;

        int roll, checkOption;
        int finalPosition = 100;
        Random rand = new Random();
        public void StartGame()
        {

            PlayerOne();
        }
        public void PlayerOne()
        {
            if (playerOnePosition == finalPosition)
            {
                Console.WriteLine("Congratulations player 1");
                Console.WriteLine("Better luck next time player 2");
                Console.WriteLine("roll " + countRoll);
                return;
            }
            roll = rand.Next(1, 7);
            checkOption = rand.Next(1, 4);
            Console.WriteLine("Player One Dice Roll = " + ++countRollP1);
            ++countRoll;
            switch (checkOption)
            {
                case Not_Play:
                    Console.WriteLine("No play --> Player One position= " + playerOnePosition);
                    PlayerTwo();
                    break;
                case Ladder:
                    playerOnePosition += roll;
                    playerOnePosition = playerOnePosition > finalPosition ? (playerOnePosition - roll) : playerOnePosition;
                    Console.WriteLine("Ladder --> Player One position= " + playerOnePosition);
                    PlayerOne();
                    break;
                case Snake:
                    playerOnePosition = (playerOnePosition - roll) < 0 ? 0 : (playerOnePosition - roll);
                    Console.WriteLine("Snake --> Player One position= " + playerOnePosition);
                    PlayerTwo();
                    break;
                default:
                    break;

            }
        }
        public void PlayerTwo()
        {
            if (playerTwoPosition == finalPosition)
            {
                Console.WriteLine("Congratulations player 2");
                Console.WriteLine("Better luck next time player 1");
                Console.WriteLine("Total Dice Roll = " + countRoll);
                return;
            }
            roll = rand.Next(1, 7);
            checkOption = rand.Next(1, 4);
            Console.WriteLine("Player Two Dice Roll = " + ++countRollP2);
            ++countRoll;
            switch (checkOption)
            {
                case Not_Play:
                    Console.WriteLine("No play --> Player Two position= " + playerTwoPosition);
                    PlayerOne();
                    break;
                case Ladder:
                    playerTwoPosition += roll;
                    // condition to check whether player position be exactly 100
                    playerTwoPosition = playerTwoPosition > finalPosition ? (playerTwoPosition - roll) : playerTwoPosition;
                    Console.WriteLine("Ladder --> Player Two position= " + playerTwoPosition);
                    PlayerTwo();
                    break;
                case Snake:
                    playerTwoPosition = (playerTwoPosition - roll) < 0 ? 0 : (playerTwoPosition - roll);
                    Console.WriteLine("Snake --> Player Two position= " + playerTwoPosition);
                    PlayerOne();
                    break;
                default:
                    break;
            }

        }
    }
}

