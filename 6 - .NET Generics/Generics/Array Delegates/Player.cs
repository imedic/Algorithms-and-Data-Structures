using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Delegates
{
    class Player
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(int number, string name, int score)
        {
            Number = number;
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return Number + ". " + Name + ": " + Score;
        }
    }
}
