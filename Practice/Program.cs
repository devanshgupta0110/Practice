using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	class Program
	{


		static void Main()
		{
			int rows = 4; // Number of rows in the pyramid

			for (int i = 1; i <= rows; i++)
			{
				// Print spaces for alignment
				for (int j = 1; j <= rows - i; j++)
				{
					Console.Write(" ");
				}

				// Print asterisks
				for (int k = 1; k <= i; k++)
				{
					Console.Write("* ");
				}

				Console.WriteLine(); // Move to the next line after each row
			}
		}
	}
}