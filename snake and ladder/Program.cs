using System;

namespace snake_and_ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("snake and ladder game !!!!");
            RollDice rd = new RollDice();
            rd.StartGame();
        }
    }
}
