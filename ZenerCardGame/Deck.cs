using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenerCardGame
{
    public class DeckOfCards : Card
    {
        public int NumOfCards {get; set;}
        public Card[] Deck { get; set; }

        public DeckOfCards() { }
        public DeckOfCards(int numOfCards, Card[] deck)
        {
            NumOfCards = numOfCards;
            Deck = deck;
        }
        

        public void SetUpDeck(int numOfCards)
        {
            
            Random rnd = new Random();
            for (int i = 0; i < numOfCards; i++)
            {
                Deck[i] = new Card { TypeOfSuit = (SuitType)rnd.Next(1, 4) };
            }
        }
    }
}
