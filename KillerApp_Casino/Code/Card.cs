using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace KillerApp_Casino.Code
{
	public class Card
	{
		public int Value { get; set; }
		public string Type { get; set; }
		public Image Image { get; set; }

		public Card(Image img, int value, string type)
		{
			this.Image = img;
			Value = value;
			Type = type;
		}
		
		
	}
}