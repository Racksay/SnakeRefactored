

namespace ConsoleApplication1
{
	public class Direction
	{
		public Dir NewDirection { get; set; }
		public Dir LastDirection { get; set; }

		public Direction()
		{
			NewDirection = Dir.Down;
			LastDirection = NewDirection;
		}

		public void SetDirectionUp()
		{
			NewDirection = Dir.Up;
		}
		public void SetDirectionDown()
		{
			NewDirection = Dir.Down;
		}
		public void SetDirectionLeft()
		{
			NewDirection = Dir.Left;
		}
		public void SetDirectionRight()
		{
			NewDirection = Dir.Right;
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
