using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CardGameCollections
{
    public class Deck<T> : IEnumerable
    {
        // instantiation of our deck
        T[] deck = new T[53];
        // the amt of cards that are in the deck
        int count;
        // adding a card to deck
        public bool Add (T card)
        {
            // resizing the deck to ensure that we have more rom
            if(count == deck.Length)
            {
                // the deck is an array, so we are doubling the length
                Array.Resize(ref deck, deck.Length *2);
            }
            // increasing the count of the deck per card
            deck[count++] = card;
            return true;
        }

        // remocing a card from the deck
        public bool Remove(T item)
        {
            for(int i=0; i<count; i++)
            {
                if (item.Equals(deck[i]))
                {
                    deck[i] = default;
                    count--;
                    return true;
                }
            }
            return false;
        }

        // shuffles/randomizes the card positions in the deck
        public bool Shuffle ()
        {
            try
            {
                int c = deck.Length;
                Random rnd = new Random();
                while (c > 1)
                {
                    c--;
                    int d = rnd.Next(c+1);
                    T newPos = deck[d];
                    deck[d] = deck[c];
                    deck[c] = newPos;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($@"Sorry, something went wrong {e.Message}");
                return false;
            }

            // wait.... what??
            public IEnumerator<T> GetEnumerator()
            {
                for (int i=0; i<count; i++)
                {
                    yield return deck[i];
                }
            }

            // WTF?!?! why is this unreachable?!?!
            IEnumerator IEnumerable.GetEnumerator() 
            {
                return GetEnumerator();
            }
        }
    }
}
