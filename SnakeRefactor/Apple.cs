using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public class Apple : PlayField
	{
		public Coord AppleCoord { get; set; }
		private readonly Random _random = new Random();
		private readonly FieldRenderer _renderer = new FieldRenderer();

		public Apple()
		{
			AppleCoord = new Coord();
		}

		public bool SetAppleOnField(List<Coord> tailCoords, int width, int height)
		{
			while (true)
			{
				AppleCoord.X = _random.Next(0, width);
				AppleCoord.Y = _random.Next(0, height);

				var freeSpot = tailCoords.All(i => i.X != AppleCoord.X || i.Y != AppleCoord.Y);
				if (!freeSpot) continue;

				_renderer.DrawCharAtLoc(AppleCoord, '$');

				return true;
			}
		}
	}
}
