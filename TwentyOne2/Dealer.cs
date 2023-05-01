﻿using System;

public class Dealer
{
    public string Name { get; set; }
    public Deck Deck  { get; set; }
    public int Balance { get; set; }

    public void Deal(List<Card> Hand)
    {
        Hand.Add(Deck.Cards.First()); 
        Console.WriteLine(Deck.Cards.First().ToString() + "\n");
        Deck.Cards.RemoveAt(0);
    }
}
