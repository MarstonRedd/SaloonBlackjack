using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaloonBlackjack
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        private Random rng = new Random();

        public Deck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    cards.Add(new Card { Suit = suit, Rank = rank });
                }
            }
        }

        public void Shuffle()
        {
            cards = cards.OrderBy(c => rng.Next()).ToList();
        }

        public Card DrawCard()
        {
            if (cards.Count == 0) return null;

            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public void Reset()
        {
            cards.Clear();
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    cards.Add(new Card { Suit = suit, Rank = rank });
                }
            }
            Shuffle();
        }
    }
}
