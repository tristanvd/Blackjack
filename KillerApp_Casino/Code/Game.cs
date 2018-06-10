using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp_Casino.Code
{
	public class Game
	{
		
		public Deck deck;

		public int Bet { get; set; } = 1;
		public bool Active = false;

		public decimal Profits;

		public List<Player[]> AllPlayers = new List<Player[]>();



		public Player[] player = new Player[4];

		public Game()
		{
			Active = true;
		}

		public void AddPlayers(int p1, int p2, int p3)
		{
			if (p1 > 0)
			{

				player[1] = new Player();
				player[1].Bet = p1;

			}
			if (p2 > 0)
			{

				player[2] = new Player();
				player[2].Bet = p2;
			}
			if (p3 > 0)
			{

				player[3] = new Player();
				player[3].Bet = p3;
			}

			player[0] = new Player();


			deck = new Deck();
			Active = true;

			NextPlayer(0);
		}



		public void Hit(int x)
		{
			try
			{
				player[x].hand.CardsInHand.Add(player[x].hand.GetCard(deck));
				player[x].hand.HandValue += player[x].hand.GetCard(deck).Value;
				deck.FullDeck.Remove(player[x].hand.GetCard(deck));
			}
			catch
			{

			}
		}

		public void NextPlayer(int x)
		{
			player[x].Active = false;

			try
			{
				player[x + 1].Active = true;
			}
			catch
			{
				try { player[x + 2].Active = true; }
				catch
				{
					try { player[x + 3].Active = true; }
					catch
					{
						try { player[1].Active = false; }
						catch { }
						try { player[2].Active = false; }
						catch { }
						try { player[3].Active = false; }
						catch { }
						Active = false;

					}
				}

			}
		}

		public void CheckGameEnded()
		{
			if (Active == false)
			{
				//afgelopen

			}
		}

		public void CheckWin(int x /* user currentuser */)
		{


			if (player[x].Blackjack == true && player[0].Blackjack == false)
			{
				Profits += player[x].Bet * Convert.ToDecimal(2.5);
			}
			else if (player[x].Blackjack == true && player[0].Blackjack == true)
			{
				Profits += 0;
			}
			else if (player[x].hand.HandValue > player[0].hand.HandValue && player[x].hand.HandValue <= 21)
			{
				Profits += player[x].Bet * 2;
			}
			else if (player[x].hand.HandValue == player[0].hand.HandValue && player[x].hand.HandValue <= 21)
			{
				Profits += player[x].Bet;
			}
			else if (player[x].hand.HandValue < player[0].hand.HandValue || player[x].hand.HandValue > 21)
			{
				Profits += 0;
			}





			//update balance
		}

	}
}