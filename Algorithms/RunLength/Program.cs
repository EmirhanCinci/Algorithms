namespace RunLength
{
	// A method that determines the number of consecutive letters in a given string.

	// Example input: RunLength("aaabbcde")
	//		  Output: 3a2b1c1d1e

	// Example input: RunLength("wwwbbw")
	//		  Output: 3w2b2w

	internal class Program
	{
		public static string RunLength(string txt)
		{
			string result = "";
			char character = txt[0];
			int counter = 1;
			for (int i = 1; i < txt.Length; i++)
			{
				if (txt[i] == character)
				{
					counter++;
				}
				else
				{
					result += counter + character.ToString();
					character = txt[i];
					counter = 1;
				}
			}
			if (txt[txt.Length - 1] == character)
			{
				result += counter + character.ToString();
			}
			else
			{
				counter = 1;
				result += counter + character.ToString();
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(RunLength("aaabbcde"));
			Console.WriteLine(RunLength("wwwbbw"));
		}
	}
}
