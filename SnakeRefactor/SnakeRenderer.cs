using System;

namespace ConsoleApplication1
{
	public class SnakeRenderer : Renderer
	{
		public override void Render(Coord coord, char c)
		{
			Draw(coord, c, ConsoleColor.Yellow);
		}
	}
}