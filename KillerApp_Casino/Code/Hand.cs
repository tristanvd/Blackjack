using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp_Casino.Code
{
	public class Hand
	{
		public List<Card> CardsInHand = new List<Card>();
		public int HandValue { get; set; } = 0;

		public Card GetCard(Deck deck)
		{
			Random rnd = new Random();
			int number = rnd.Next(deck.FullDeck.Count);
			Card randomcard = deck.FullDeck[number];

			return randomcard;
		}

	}
}