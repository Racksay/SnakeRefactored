using System;

namespace ConsoleApplication1
{
    public abstract class Renderer
	{ 
	    public abstract void Render(Coord coord, char c);

	    protected void Draw(Coord coord, char c, ConsoleColor color)
	    {
		    Console.ForegroundColor = color;
			Console.SetCursorPosition(coord.X, coord.Y);
			Console.Write(c);
	    }
    }
}
