using System;

namespace CardGameCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PopulateTheDeck();
        }
        static void PopulateTheDeck()
        {
            Card card1 = new Card()
            {
                Color = "red",
                Number = 5,
                Suit = Suit.Heart
            };
            Card card2 = new Card() 
            { 
                Color = "black",
                Number = 13,
                Suit = Suit.Club
            };
            Card card3 = new Card() 
            {
                Color = "black",
                Number = 1,
                Suit = Suit.Spade
            };
            Card card4 = new Card() 
            {
                Color = "black",
                Number = 7,
                Suit = Suit.Club
            };
            Deck<Card> myCards = new Deck<Card>{card1, card2, card3, card4};
            Deal (myCards);
            // removal magic
            myCards.Remove(card2);
            // adding magic
            myCards.Add(card2);
        }
        public static void Deal(Deck<Card> myCards)
        {
            foreach (Card card in myCards)
            {
                Console.WriteLine(card.Suit);
            }

            // e'ray day im shuffling
            myCards.Shuffle();
            int m=0;
            foreach(Card Card in myCards)
            {
                m++;
                if (Card != null)
                {
                    Console.WriteLine($"{m} -- {Card.Color}");
                }
            }
        }
    }
}
