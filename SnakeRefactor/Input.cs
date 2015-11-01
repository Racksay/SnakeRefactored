using System;

namespace ConsoleApplication1
{
	class Input
	{
		private ConsoleKeyInfo KeyInfo { get; set; }
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

		public bool KeyAvalible() {	 return !Console.KeyAvailable;	}

		public bool Pause()	{	return KeyInfo.Key == ConsoleKey.Spacebar;	}

		public bool Quit() 	{	return KeyInfo.Key != ConsoleKey.Escape;	}

		public bool Up(Direction direction)
		{
			return KeyInfo.Key == ConsoleKey.UpArrow && direction.LastDirection != Direction.Dir.Down;
		}

		public bool Down(Direction direction)
		{
			return KeyInfo.Key == ConsoleKey.DownArrow && direction.LastDirection != Direction.Dir.Up;
		}

		public bool Right(Direction direction)
		{
			return KeyInfo.Key == ConsoleKey.RightArrow && direction.LastDirection != Direction.Dir.Left;
		}

		public bool Left(Direction direction)
		{
			return KeyInfo.Key == ConsoleKey.LeftArrow && direction.LastDirection != Direction.Dir.Right;
		}
	}
}
