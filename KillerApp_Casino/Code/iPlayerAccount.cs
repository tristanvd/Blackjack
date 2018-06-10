using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerApp_Casino.Code
{
	public interface iPlayerAccount
	{
		string Id { get; }
		double Balance { get; }
		void Credit(double amount);
		void Debit(double amount);
	}
}
