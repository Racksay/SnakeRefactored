using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public class FieldRenderer : Renderer
	{
		public override void DrawCharAtLoc(Coord coord, char c)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.SetCursorPosition(coord.X, coord.Y);
			Console.Write(c);
		}

		public void InitConsole()
		{
			Console.CursorVisible = false;
			Console.Title = "Westerdals Oslo ACT - SNAKE";
			Console.ForegroundColor = ConsoleColor.Green;
			Console.SetCursorPosition(10, 10);
			Console.Write("@");
		}
	}
}