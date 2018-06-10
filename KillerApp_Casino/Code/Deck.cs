using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp_Casino.Code
{
	public class Deck
	{
		public List<Card> FullDeck = new List<Card>();
		public List<Card> AllCardsOnTable = new List<Card>();

		// closed card   public Card card = new Card(Properties.Resources.BlackjackCardBack, 0, "ClosedCard");


		public Deck()
		{
			//get cards from database
		}
	}
}