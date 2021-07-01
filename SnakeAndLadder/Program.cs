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

        //public static int Roll_Dice()
        //{
        // random value is given to palyer's dice
        //return random.Next(1, 7);
        // }
        public static int PlayerMoves(int playerRollDice)
        {
            int playerMove = 0;
            // Player Option is gentrated..
            int option = random.Next(0, 3);
            switch (option)
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
            Console.WriteLine("Wellcome To Snake and Ladder game");
            // Number of players are created 
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            bool endGame = false;
            Player currentPlayer = player1;


            //Repeats till the Player reaches the winning position 100.
            while (!endGame)
            {
                // player rolls the dice and gets the value
                int player_Roll_Dice = random.Next(1, 7);

                // number of times the dice was played is counted
                currentPlayer.countOfDiceRolled++;

                // The Player then checks for a Option. They are No_Play,Ladder and Snake.
                int player_move = PlayerMoves(player_Roll_Dice);
                if (currentPlayer.playerPosition + player_move == FINAL_POSITION)
                {
                    currentPlayer.playerNextMove = FINAL_POSITION;
                    Console.WriteLine(currentPlayer.playerName + " current position after rolling the Dice is " + currentPlayer.playerNextMove);
                    Console.WriteLine();
                    Console.WriteLine("The Winner is " + currentPlayer.playerName);
                    Console.WriteLine("Total Number of times Dice Rolled in the game by " + currentPlayer.playerName + " is " + currentPlayer.countOfDiceRolled);
                    System.Environment.Exit(0);
                }
                else if (currentPlayer.playerPosition + player_move > FINAL_POSITION)
                    currentPlayer.playerNextMove = currentPlayer.playerPosition;
                else
                    currentPlayer.playerNextMove = currentPlayer.playerPosition + player_move;

                if (currentPlayer.playerNextMove < START_POSITION)
                    currentPlayer.playerPosition = START_POSITION;
                else
                    currentPlayer.playerPosition = currentPlayer.playerNextMove;

                // Player current position After rolling the Dice
                Console.WriteLine(currentPlayer.playerName + " current position after rolling the Dice is " + currentPlayer.playerPosition);
                if (player_move == 6)
                {
                    continue;
                }
                else
                {
                    if (currentPlayer == player1)
                        currentPlayer = player2;
                    else
                        currentPlayer = player1;
                }
            }

        }

    }
}



