﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{
    /// <summary>
    /// I did that game
    /// </summary>
    public class Game
    {
        public bool turn { get; set; }
        public byte numTurns { get; set; }

        const byte maxNumTurns = 10;
       
        public bool ChangeTurn(bool turn) 
        {
            return turn = !turn;
        }

        /// <summary>
        /// This method returns true if there are no more turns left in the game, otherwise it returns false
        /// </summary>
        /// <param name="numTurns"></param>
        /// <returns>Boolean</returns>
        public bool OutOfTurns(int numTurns)
        {
            if (numTurns < 0) throw new ArgumentOutOfRangeException("Number of turns cannot be negative");
            if (numTurns > maxNumTurns)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// This method checks which player won and returns the name of the player or the string "Everybody" if it was a tie
        /// </summary>
        /// <param name="p1">Player 1 object</param>
        /// <param name="p2">Player 2 object</param>
        /// <returns>string</returns>
        public string CheckWinner(Player p1, Player p2)
        {
            if (p1.PlayerScore > p2.PlayerScore)
            {
                return p1.PlayerName;
            }
            else if (p2.PlayerScore > p1.PlayerScore)
            {
                return p2.PlayerName;
            }
            else
            {
                return "Everybody";
            }

        }

        /// <summary>
        /// This method returns the number of turns left in the game
        /// </summary>
        /// <param name="numTurns">Number of turns played so far in game</param>
        /// <returns>int</returns>
        public int TurnsLeft(int numTurns)
        {
            if (numTurns < 0) throw new ArgumentOutOfRangeException("Number of turns cannot be negative");
            return maxNumTurns - numTurns;
        }


    }
}
