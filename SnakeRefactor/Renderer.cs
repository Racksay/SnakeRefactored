using System;

namespace ConsoleApplication1
{
    public abstract class Renderer : SnakeGame
	{ 
	    public abstract void DrawCharAtLoc(Coord coord, char c);
    }
}
