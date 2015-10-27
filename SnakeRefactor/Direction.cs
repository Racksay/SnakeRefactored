using System;

namespace ConsoleApplication1
{
	public class Direction : Snake
	{
		public Dir NewDirection { get; set; }
		public Dir LastDirection { get; set; }

		public Direction()
		{
			NewDirection = Dir.Down;
			LastDirection = NewDirection;
		}

		public enum Dir
		{
			Up,
			Right,
			Down,
			Left
		};

	}
}
