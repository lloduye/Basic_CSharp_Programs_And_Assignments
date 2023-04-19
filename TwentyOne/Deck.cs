using System;
//Create a Deck Class
public class Deck
{
	//This is a constructor method for creating a deck of card
	//through for each loop to create a total of 52 cards in one instance
	public Deck()
	{	//instantiating the property cards as an empty list of cards
		Cards = new List<Card>();

		//Creating two lists; Faces list and Suits list
		List<string> Suits = new List<string>() {"Clubs", "Hearts" ,"Diamonds" ,"Spades"};
		List<string> Faces = new List<string>()
		{
			"Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
			"Jack", "Queen", "Ace"
		};
		//Create foreach loop constructor to create card
		foreach (string face in Faces)
		{
			foreach (string suit in Suits)
			{
				Card card = new Card();
				card.Suit = suit;
				card.Face = face;
				Cards.Add(card);
			}
		}
	}
	//Create a property of list cards with attributes
	public List<Card> Cards { get; set; }
}
