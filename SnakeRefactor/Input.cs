using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Input : SnakeGame
	{
		public ConsoleKeyInfo KeyInfo { get; set; }
		public bool InputAvaliable { get; set; }

		public Input()
		{
			if (KeyAvalible())
			{
				InputAvaliable = false;
				return;
			}
			InputAvaliable = true;
			KeyInfo = Console.ReadKey(true);				
		}

		public bool KeyAvalible()
		{
			return !Console.KeyAvailable;		
		}

		public bool Pause()
		{
			return KeyInfo.Key == ConsoleKey.Spacebar;
		}

		public bool Quit() 
		{
			return KeyInfo.Key != ConsoleKey.Escape;
		}

		public Direction.Dir Up(Direction direction)
		{
			if (KeyInfo.Key == ConsoleKey.UpArrow && direction.LastDirection != Direction.Dir.Down)
				return Direction.Dir.Up;
			return Direction.Dir.Down;
		}

		public Direction.Dir Down(Direction direction)
		{
			if (KeyInfo.Key == ConsoleKey.DownArrow && direction.LastDirection != Direction.Dir.Up)
				return Direction.Dir.Down;
			return Direction.Dir.Up;
		}

		public Direction.Dir Right(Direction direction)
		{
			if (KeyInfo.Key == ConsoleKey.RightArrow && direction.LastDirection != Direction.Dir.Left)
				return Direction.Dir.Right;
			return Direction.Dir.Left;
		}

		public Direction.Dir Left(Direction direction)
		{
			if (KeyInfo.Key == ConsoleKey.LeftArrow && direction.LastDirection != Direction.Dir.Right)
				return Direction.Dir.Left;
			return Direction.Dir.Right;
		}
	}
}
