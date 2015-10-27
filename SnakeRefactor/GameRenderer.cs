using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public class GameRenderer : Renderer
	{
		public override void DrawCharAtLoc(Coord coord, char c)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(coord.X, coord.Y);
			Console.Write(c);
		}
	}
}