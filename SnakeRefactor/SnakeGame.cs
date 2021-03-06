﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApplication1
{
    public class SnakeGame
	{
		private bool GameIsPlaying { get; set; }
		private bool AppleEaten { get; set; }
		private bool Paused { get; set; }

	    public List<Coord> TailCoordsList;
		private PlayField PlayField { get; set; }
		private Snake Player { get; set; }
		private Stopwatch Tick { get; set; }
        private SnakeRenderer Renderer { get; set; }
		private Direction Direction { get; set; }
		private Input Input { get; set; }


		private void Initiliaze()
		{
			GameIsPlaying = true;
			Paused = false;
			AppleEaten = false;

			TailCoordsList = new List<Coord>();

			PlayField = new PlayField(TailCoordsList);

			Tick  = new Stopwatch();
			Renderer = new SnakeRenderer();

			Player = new Snake(TailCoordsList);
			Direction = new Direction();
			
			Tick.Start();
			UpdatePlayField();
		}

		private void UpdatePlayField()
		{
			while (GameIsPlaying)
			{
				OnKeyDown(); // Input logic

				if (!Paused) // Game logic
				{
					if (Tick.ElapsedMilliseconds < 100) continue; // Tick ensures that each update will happen in constant time.
					Tick.Restart();

					Player.GetNextPosition(TailCoordsList);
					Player.SwitchDirection(Direction.NewDirection);

					GameIsPlaying = Player.BorderCollisionCheck(PlayField.Width, PlayField.Height);
					if (!GameIsPlaying) continue;

                    AppleEaten = PlayField.AppleCollisionCheck(TailCoordsList, Player.NewHeadCoord);

                    GameIsPlaying = Player.SelfCollisionTest(TailCoordsList, AppleEaten);
					if (!GameIsPlaying) continue;

					Renderer.Render(Player.HeadCoord, '0');

					if (!AppleEaten)
						Renderer.Render(Player.TailEndCoord, ' ');
					else
						AppleEaten = true;
			
					Player.ExtendSnakeTail(TailCoordsList);
					Renderer.Render(Player.NewHeadCoord, '@');
					Direction.LastDirection = Direction.NewDirection;

				}
			}
		}

		private void OnKeyDown()
		{
			Input = new Input();
			if (!Input.InputAvaliable) return;
			if(!Input.Quit())
				GameIsPlaying = Input.Quit();
			else if (Input.Pause())
				Paused = !Paused;
			else if (Input.Up(Direction))
				Direction.SetDirectionUp();
			else if (Input.Down(Direction))
				Direction.SetDirectionDown();
			else if (Input.Left(Direction))
				Direction.SetDirectionLeft();
			else if (Input.Right(Direction))
				Direction.SetDirectionRight();
		}

		public void InitConsole()
		{
			Console.CursorVisible = false;
			Console.Title = "Westerdals Oslo ACT - SNAKE";
			Console.ForegroundColor = ConsoleColor.Green;
			Console.SetCursorPosition(10, 10);
			Console.Write("@");
		}

		public static void Main()
		{
			var game = new SnakeGame();
			game.Initiliaze();
		}
	}
}
