using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp_Casino.Code
{
	public class Game
	{
		private Dealer dealer;
		private List<Player> players;

		public Hand DealerHand { get { return DealerHand; } }

		public Game()
		{
			dealer = new Dealer();
			players = new List<Player>(3);
		}

		public void AddPlayer(iPlayerAccount account, int position)
		{
			players.Add(new Player(account, this, position));
		}

		public void RemovePlayer(Player player)
		{
			if (players.Contains(player))
			{
				if (player.IsLive)
				{
					throw new InvalidOperationException("Player is in live round");
				}

				players.Remove(player);
			}
		}

		public virtual void StartRound()
		{
			dealer.Deal(players);
		}

		

	}
}