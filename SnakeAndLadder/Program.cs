using System;

namespace SnakeAndLadder
{
    class Program
    {
        //Sarting Position  of the game is 0
        public const int START_POSITION = 0;
        //Final Position is 100 and if the player reach 100 he wins the game
        public const int FINAL_POSITION = 100;
        public static Random random = new Random();
        //Initializing Options
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public static int PlayerMoves(int playerRollDice)
        {
            int playerMove = 0;
            int option = random.Next(0,3);
            switch(option)
            {
                case LADDER:
                    Console.WriteLine("Hurray! It's ladder");
                    playerMove = playerRollDice;
                    break;
                case SNAKE:
                    Console.WriteLine("OMG! It's snake");
                    playerMove = -playerRollDice;
                    break;
                default:
                    Console.WriteLine("No Play");
                    break;

            }
            return playerMove;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Game");
            //Initial Position of the Player
            int playerPosition = 0;
            Console.WriteLine("Player Initial Position : "+playerPosition);
            //Player rolls the dice and gets value of the dice
            int playerRollDice = random.Next(1, 7);
            Console.WriteLine("Player Dice Value is : "+playerRollDice);
            int playerCurrentMove = PlayerMoves(playerRollDice);
            int playerNextMove = playerPosition + playerCurrentMove;
            if(playerNextMove<START_POSITION)
            {
                playerPosition = START_POSITION;
            }
            else
            {
                playerPosition = playerNextMove;
            }
            Console.WriteLine("Player Current Position is : "+playerPosition);
        }
    }
}
