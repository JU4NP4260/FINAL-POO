using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_simple_POO
{
    internal class Player
    {
        public string playerName, playerRace;

        public Player(string playerName, string playerRace)
        {
            this.playerName = playerName;
            this.playerRace = playerRace;
        }
    }
}
