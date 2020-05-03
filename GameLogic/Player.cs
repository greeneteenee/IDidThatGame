using System;

namespace GameLogic
{
    public class Player
    {
        //CONSTRUCTOR: Player must have PlayerName
        public Player()
        {

        }

        //PROPERTIES
        public string PlayerName { get; set; }
        public int PlayerScore { get; private set; } = 0;

        /// <summary>
        /// Takes a Player object and adds 1 point to the player's score
        /// </summary>
        /// <param name="currPlayer"></param>
        public void UpdatePlayerScore(Player currPlayer)
        {
            currPlayer.PlayerScore += 1;
        }

    }
}
