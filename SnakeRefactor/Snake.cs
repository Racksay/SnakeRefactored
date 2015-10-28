using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
	public class Snake : SnakeGame
	{		
		public Coord TailEndCoord { get; set; }
		public Coord HeadCoord { get; set; }
		public Coord NewHeadCoord { get; set; }

		
		public Snake(List<Coord> tailCoords)
		{
			FillTail(tailCoords);
		}

		public void FillTail(List<Coord> tailCoords)
		{
			tailCoords.Add(new Coord(10, 10));
			tailCoords.Add(new Coord(10, 10));
			tailCoords.Add(new Coord(10, 10));
			tailCoords.Add(new Coord(10, 10));
		}

		public void GetNextPosition(List<Coord> tailCoords)
		{
			TailEndCoord = new Coord(tailCoords.First());
			HeadCoord = new Coord(tailCoords.Last());
			NewHeadCoord = new Coord(HeadCoord);

		}

		public void SwitchDirection(Direction.Dir newDir)
		{
			switch (newDir)
			{
				case Direction.Dir.Up:
					NewHeadCoord.Y--;
					break;
				case Direction.Dir.Right:
					NewHeadCoord.X++;
					break;
				case Direction.Dir.Down:
					NewHeadCoord.Y++;
					break;
				default:
					NewHeadCoord.X--;
					break;
			}
		}

		public bool BorderCollisionCheck(int width, int height)
		{
			if (NewHeadCoord.X < 0 || NewHeadCoord.X >= width)
				return false;
			if (NewHeadCoord.Y < 0 || NewHeadCoord.Y >= height)
				return false;
			return true;
		}

		// Death by accidental self-cannibalism.
		public bool SelfCollisionTest(List<Coord> tailCoords, bool appleEaten)
		{
			if (!appleEaten)
			{
				tailCoords.RemoveAt(0);
				foreach (Coord x in tailCoords)
					if (x.X == NewHeadCoord.X && x.Y == NewHeadCoord.Y)
					{
						// Death by accidental self-cannibalism.
						return false;
					}
			}
            return true;
		}

		public void ExtendSnakeTail(List<Coord> tailCoords)
		{
			tailCoords.Add(new Coord(NewHeadCoord));
		}
    }
}
