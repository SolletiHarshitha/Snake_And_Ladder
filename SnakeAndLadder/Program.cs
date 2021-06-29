using System;

namespace SnakeAndLadder
{
    class Program
    {
        //Sarting Position is 0
        public const int START_POSITION = 0;
        //Final Position is 100 and if the player reach 100 he wins the game
        public const int FINAL_POSITION = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Game");
            //Initial Position of the Player
            int playerPosition = 0;
            Console.WriteLine("Player Initial Position : "+playerPosition);
            Random random = new Random();
            //Player rolls the dice and gets value of the dice
            int playerRollDice = random.Next(1, 7);
            Console.WriteLine("Player Dice Value is : ",+playerRollDice);

        }
    }
}
