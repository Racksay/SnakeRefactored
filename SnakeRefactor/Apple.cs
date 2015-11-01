using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
	public class Apple
	{
		private static readonly Random Random = new Random();
		public Coord AppleCoordinate { get; set; }

		private readonly Renderer _renderer;
		private readonly int _playFieldWidth;
		private readonly int _playFieldHeight;

		public Apple(Renderer renderer, PlayField playField)
		{
			_renderer = renderer;
			AppleCoordinate = new Coord();
			_playFieldHeight = playField.Height;
			_playFieldWidth = playField.Width;
		}

		public bool SetAppleOnField(List<Coord> tailCoords)
		{
			var isValidAppleCoordinate = false;
			while (!isValidAppleCoordinate)
			{
				AppleCoordinate.X = Random.Next(0, _playFieldWidth);
				AppleCoordinate.Y = Random.Next(0, _playFieldHeight);

				isValidAppleCoordinate = tailCoords.All(i => i.X != AppleCoordinate.X || i.Y != AppleCoordinate.Y);
			
			}
			_renderer.Render(AppleCoordinate, '$');
			return true;
		}
	}
}
