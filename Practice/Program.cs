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
			string word = "INTERVIEW"; // The word to build up
			int length = word.Length;  // Length of the word

			for (int i = 0; i < length; i++)
			{
				// Print the substring from index 0 to i+1
				Console.WriteLine(word.Substring(0, i + 1));
			}
		}
	}

}