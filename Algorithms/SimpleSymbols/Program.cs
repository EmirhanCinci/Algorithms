namespace SimpleSymbols
{
	// Write a function that takes a string as input and determines whether it is a valid string according to the following rules:
	// The string will consist of characters along with '+' and '=' symbols. For the string to be considered valid:
	// - Every letter must be surrounded by '+' symbols on both sides.
	// The string will not be empty and will contain at least one letter.

	// Example Input: Console.WriteLine(SimpleSymbols("++d+===+c++==a"));
	//        Output: false

	// Example Input: Console.WriteLine(SimpleSymbols("+d+=3=+s+"));
	//		  Output: true

	// Example Input: Console.WriteLine(SimpleSymbols("f++d+"));
	//		  Output: false

	internal class Program
	{
		public static bool SimpleSymbols(string txt)
		{
			txt = txt.ToLower();
			for (int i = 0; i < txt.Length; i++)
			{
				if (i == 0 || i == txt.Length - 1)
				{
					if (txt[i] >= 97 && txt[i] <= 122)
					{
						return false;
					}
				}
				if (txt[i] >= 97 && txt[i] <= 122)
				{
					if (txt[i - 1] != '+' || txt[i + 1] != '+')
					{
						return false;
					}
				}
			}
			return true;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(SimpleSymbols("++d+===+c++==a"));
			Console.WriteLine(SimpleSymbols("+d+=3=+s+"));
			Console.WriteLine(SimpleSymbols("f++d+"));
		}
	}
}
