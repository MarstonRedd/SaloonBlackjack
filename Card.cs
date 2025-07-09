using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaloonBlackjack
{
    public class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }
        public int Value { get; set; }

        public int GetValue(int currenttotal)
        {
            if (Rank == "A")
            {
                if ((currenttotal + 11) <= 21)
                {
                    return 11; // If the player/dealer can take an Ace as 11 without busting, do so
                }
                return 1;
            }
            if (Rank == "J" || Rank == "Q" || Rank == "K") return 10;
            return int.Parse(Rank);
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
