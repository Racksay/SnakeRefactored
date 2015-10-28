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
			if (KeyInfo.Key == ConsoleKey.UpArrow && direction.LastDirection != Direction.Dir.Down)
				return true;
			return false;
		}

		public bool Down(Direction direction)
		{
			if (KeyInfo.Key == ConsoleKey.DownArrow && direction.LastDirection != Direction.Dir.Up)
				return true;
			return false;
		}

		public bool Right(Direction direction)
		{
			if (KeyInfo.Key == ConsoleKey.RightArrow && direction.LastDirection != Direction.Dir.Left)
				return true;
			return false;
		}

		public bool Left(Direction direction)
		{
			if (KeyInfo.Key == ConsoleKey.LeftArrow && direction.LastDirection != Direction.Dir.Right)
				return true;
			return false;
		}
	}
}
