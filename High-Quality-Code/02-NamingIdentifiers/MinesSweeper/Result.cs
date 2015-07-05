namespace NamingIdentifiers.Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Player
    {
        public Player() 
        { 
        }

        public Player(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public int Score { get; set; }

        public string Name { get; set; }   
    }
}
