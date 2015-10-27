using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
	public class PlayField : SnakeGame
	{
		public int Width { get; set; }
		public int Height { get; set; }
		public Apple Apple { get; set; }
		
		private readonly FieldRenderer _renderer = new FieldRenderer();
		private readonly Random _random = new Random();

		public PlayField(List<Coord> tailCoords)
		{
			SetSnakeField();
			Apple = new Apple();
			Apple.SetAppleOnField(tailCoords, Width, Height);

		}

		protected PlayField(){}

		public void SetSnakeField()
		{
			Width = Console.WindowWidth;
			Height = Console.WindowHeight;

		    _renderer.InitConsole();
		}
		public bool AppleCollisionCheck(List<Coord> tailCoords, Coord newHeadCoord)
		{
			if (newHeadCoord.X == Apple.AppleCoord.X && newHeadCoord.Y == Apple.AppleCoord.Y)
			{
				if (tailCoords.Count + 1 >= Height * Width)
					// No more room to place apples -- game over.
					Environment.Exit(0);
				else
				{
					return Apple.SetAppleOnField(tailCoords, Width, Height);
				}
			}
			return false;
		}
	}
}
