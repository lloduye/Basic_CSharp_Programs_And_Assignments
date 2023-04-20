using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiating a deck by creating a deck
            Deck deck = new Deck();

            //Return deck
            deck= Shuffle(deck, 3);

            //printing all the cards in the deck to console
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            //Cards count method to see how many cards are there
            Console.WriteLine(deck.Cards.Count);
        }

        //Create a shuffle function that takes in a deck of cards,
        //shuffles them and returns a shuffled deck
        public static Deck Shuffle(Deck deck, int times = 1)
        {
            for (int i = 0; i < times; i++)
            {

            }
            //create a temporary list of cards
            List<Card> Templist = new List<Card>();
            //instantite a random by creating random
            Random random = new Random();

            //Create while loop
            while (deck.Cards.Count > 0)
            {
                //create a random index
                int randomindex = random.Next(0, deck.Cards.Count);
                //Add deck of cards to a temporary list created
                Templist.Add(deck.Cards[randomindex]);
                //Remove deck of cards to a temporary list created
                deck.Cards.RemoveAt(randomindex);
            }
            deck.Cards = Templist;
            return deck;
        }
           
    }
}
