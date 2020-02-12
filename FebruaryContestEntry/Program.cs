using System;

namespace FebruaryContestEntry
{
	class Program
	{
		const char			block = '▓';
		const int			Width = 30;
		const int			Tall = 15;
		const int			Margin = 1;
		const ConsoleColor	MarginColor = ConsoleColor.Green;
		const ConsoleColor	CenterColor = ConsoleColor.Yellow;
		static void Main(string[] args)
		{
			// The solution implementation goes here

			Console.ResetColor();

			for(int row = 0; row < Tall; row++)
			{
				for(int column = 0; column < Width; column++)
				{
					setColor(row, column);
					Console.Write(block);
				}				
				Console.WriteLine();
			}
			//Console.WriteLine("123456789012345678901234567890");
			Console.ResetColor();			
			Console.ReadLine();
		}

		private static void setColor(int row, int col)
		{
			if (isMargin(row, col))
			{
				Console.BackgroundColor = MarginColor;
			}
			else
			{
				Console.BackgroundColor = CenterColor;
			}			
		}

		private static bool isMargin(int row, int col)
		{
			if (col < Margin || col >= Width - Margin) return true;
			if (row < Margin || row >= Tall - Margin) return true;
			return false;
		}
	}
}
