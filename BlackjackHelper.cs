using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaloonBlackjack
{
    public class BlackjackHelper
    {
        public int CardTotal { get; set; }
        private static Random random = new Random();

        public BlackjackHelper() 
        { 
        }

        public int GenerateCard(int CurrentTotal)
        {
            int cardValue = random.Next(1, 11); // Generates a random card value between 1 and 10

            if (cardValue == 1)
            {
                if ((CurrentTotal + 11) <= 21)
                {
                    cardValue = 11; // If the player/dealer can take an Ace as 11 without busting, do so
                }
            }
            
            return cardValue;
        }

        public int NewCardTotal(int playerTotal)
        {
            CardTotal = playerTotal; // Set the player's total to the given value
            return CardTotal; // Return the updated total
        }

        public bool updateDealerTotal(int dealerTotal)
        {
            CardTotal += dealerTotal; // Update the dealer's total with the new card value
            return IsBusted(); // Return true if the dealer has busted
        }

        public bool IsBusted()
        {
            return CardTotal > 21; // Check if the player's total exceeds 21
        }

        //hope
        //hope
        //hope

        string[][] deck = new string[4][]; //when initalized, this will hold 4 suits of cards


        public string[][] CreateDeck()
        {
            string[] suits = { "Hearts", "Spades", "Clubs", "Diamonds" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            for (int i = 0; i < 4; i++)
            {
                deck[i] = new string[13];
                for (int j = 0; j < 13; j++)
                {
                    deck[i][j] = $"{ranks[j]} of {suits[i]}"; // e.g., "3 of Hearts"
                }
            }

            return deck;
        }

        public int GenerateSuiteNo()
        {
            return random.Next(0, 4); // Generates a random number between 0 and 3
        }

        public int GenerateRankNo()
        {
            return random.Next(0, 13); // Generates a random number between 0 and 12
        }

        public int ReturnValue(int rankNo, int playertotal)
        {
            int value;
            if (rankNo == 0) // Ace
            {
                if (playertotal + 11 > 21)
                {
                    value = 1; // Ace is worth 1 if it would cause a bust
                }
                else
                {
                    value = 11; // Ace is worth 11 if it doesn't cause a bust
                }
            }
            else if (rankNo > 9) // Face cards (Jack, Queen, King)
            {
                value = 10; // All face cards are worth 10
            }
            else
            {
                value = rankNo + 1; // Numeric cards are worth their face value (2-10)
            }

            return value;
        }
    }
}
