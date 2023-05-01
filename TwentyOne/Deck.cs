using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //Create a Deck Class
    public class Deck
    {
        //This is a constructor method for creating a deck of card
        //through for each loop to create a total of 52 cards in one instance
        public Deck()
        {   //instantiating   the property cards as an empty list of cards
            Cards = new List<Card>();

            //Creating two lists; Faces list and Suits list and instantiate them with values
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
        {
            "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
            "Jack", "Queen","King" ,"Ace"
        };
            //Create foreach loop constructor to create card- 

            foreach (string face in Faces)
            {
                //For each of the items in list one we loop though loop
                //two the number of times of list 1 which if four times
                foreach (string suit in Suits)
                {
                    //For each loop a card is created and assigned a suite and a face

                    //Creating a we card called card
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    //adding the new card to the list of cards
                    Cards.Add(card);
                }
            }
        }
        //Create a property of list cards with attributes
        public List<Card> Cards { get; set; }
    }

}
