using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp_Casino.Code
{
	public class Player
	{
		public string Id { get; private set; }

		private Game game;

		public int Position { get; private set; }
		public iPlayerAccount Account { get; private set; }

		public bool IsLive { get { return game.GetPlayerIsLive(this); } }
		public bool HasAction { get { return game.GetPlayerHasAction(this); } }
		public double Wager { get { return game.GetPlayerWager(this); } }
		public BlackjackHand Hand { get { return game.GetPlayerHand(this); } }

		public BlackjackGamePlayer(iPlayerAccount account, Game game, int position)
		{
			if (account == null)
				throw new ArgumentNullException("account", "Account is null");

			if (game == null)
				throw new ArgumentNullException("game", "Game is null");

			_game = game;
			Alias = string.IsNullOrEmpty(alias) ? "ANON" : alias;
			Account = account;
			Position = position;
			Id = Account.Id;
		}
	}
}