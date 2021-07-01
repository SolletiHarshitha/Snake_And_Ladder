using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class Player
    {
        public int playerPosition, playerNextMove, countOfDiceRolled;
        public string playerName;
        public Player(string Name)
        {
            this.playerName = Name;
            this.playerPosition = 0;
            this.playerNextMove = 0;
            this.countOfDiceRolled = 0;
        }
    }
}
