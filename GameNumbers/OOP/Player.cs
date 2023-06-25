using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGame.OOP
{
    internal class Player
    {
        public int Username { get; set; }
        private int Password { get; set; }
        private List<Player> Friends { get; set; }
        private int WinsCount { get; set; }

        public Player( int username, int password)
        {
            Username = username;
            Password = password;
        }



    }
}
