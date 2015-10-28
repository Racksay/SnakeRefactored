using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
	public class Apple
	{
		private static readonly Random Random = new Random();
		public Coord AppleCoordinate { get { return _appleCoordinate; } }

		private readonly Coord _appleCoordinate;
		private readonly Renderer _renderer;
		private readonly int _playFieldWidth;
		private readonly int _playFieldHeight;

		public Apple(Renderer renderer, PlayField playField)
		{
			_renderer = renderer;
			_appleCoordinate = new Coord();
			_playFieldHeight = playField.Height;
			_playFieldWidth = playField.Width;
		}

		public bool SetAppleOnField(List<Coord> tailCoords)
		{
			var isValidAppleCoordinate = false;
			while (!isValidAppleCoordinate)
			{
				_appleCoordinate.X = Random.Next(0, _playFieldWidth);
				_appleCoordinate.Y = Random.Next(0, _playFieldHeight);

				isValidAppleCoordinate = tailCoords.All(i => i.X != _appleCoordinate.X || i.Y != _appleCoordinate.Y);
			
			}
			_renderer.Render(_appleCoordinate, '$');
			return true;
		}
	}
}
