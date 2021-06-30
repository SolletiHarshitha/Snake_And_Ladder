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
                    playerMove = playerRollDice;
                    break;
                case SNAKE:
                    playerMove = -playerRollDice;
                    break;
                default:
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
            while(playerPosition<FINAL_POSITION)
            {
                //Player rolls the dice and gets value of the dice
                int playerRollDice = random.Next(1, 7);
                int playerCurrentMove = PlayerMoves(playerRollDice);
                int playerNextMove = playerPosition + playerCurrentMove;
                if (playerNextMove < START_POSITION)
                {
                    playerPosition = START_POSITION;
                }
                else if(playerNextMove>FINAL_POSITION)
                {
                    playerPosition = playerNextMove - playerCurrentMove;
                }
                else
                {
                    playerPosition = playerNextMove;
                }
            }
            Console.WriteLine("Player Current Position after the game is: " + playerPosition);
        }
    }
}
