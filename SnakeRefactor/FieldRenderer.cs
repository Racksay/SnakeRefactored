using System;

namespace ConsoleApplication1
{
	public class FieldRenderer : Renderer
	{
		public override void Render(Coord coord, char c)
		{
			Draw(coord, c, ConsoleColor.Green);
		}
	}
}