using System;
using System.Collections.Generic;
using System.Text;

namespace CardGameCollections
{
    public class Card
    {
        public int Number {get; set; }
        public string Color { get; set; }
        public Suit Suit { get; set; }
    }

    /// <summary>
    /// allows us to set the suit of the card
    /// </summary>
    public enum Suit
    {
        Heart,
        Spade,
        Diamond,
        Club
    }
}
