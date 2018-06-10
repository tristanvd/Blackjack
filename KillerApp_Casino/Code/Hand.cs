using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp_Casino.Code
{
	public class Hand
	{
		public IEnumerable<Card> Cards { get; private set; }
		public Tuple<int, int> ScoreHighLow { get; private set; }
		public int Score { get; private set; }
		public bool IsBlackjack { get; private set; }
		public bool IsBusted { get; private set; }
		public bool IsSoft { get; private set; }
		
	}
}