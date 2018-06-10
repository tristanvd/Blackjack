using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp_Casino.Code
{
	public class Deck
	{
		protected List<Card> _cards;
		public IEnumerable<Card> Cards { get { return _cards; } }

		public Deck()
		{
			_cards = new List<Card>();
		}
	}
}