using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models //shouldn't need a using becaus already in the same namespace
{
    public class Deck
    {
        //Private members

            //The internal list of cards left in the deck
        private List<Card> cards;

        // Default Constructor- no parameters
        public Deck()
        {
            //Create a newly unwrapped deck of cards (ie in order)
            //need to call the constructor 52 times, 13 for each suit
            string[] suits = new string[] { "Spades", "Hearts", "Clubs", "Diamonds" };
            foreach (string suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    Card card = new Card(i, suit); //pass it a value i and a Suit
                    cards.Add(card); //adds cards to the list
                }
            }
        }
        //Returns the top card in the deck
        public Card DealOne()
        {
            if (this.cards.Count ==0) //Checks to make sure we have a deck
            {
                return null;
            }
            //The deck is not empty so deal the first card
            //remove from top of list and shrink list as we go 
            Card result = this.cards[0];
            this.cards.Remove(0);

            return result;
        }
    }
}
