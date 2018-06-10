using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp_Casino.Code
{
	public class Player
	{
		public decimal Balance { get; set; }
		public int Bet { get; set; }
		public Hand hand { get; set; }
		public bool Active = false;
		public bool Blackjack = false;

		public Player()
		{
			hand = new Hand();
		}
	}
}