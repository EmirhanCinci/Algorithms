namespace RomanToInteger
{
	// Given a Roman numeral, convert it to an integer.

	// Example input: Console.WriteLine(RomanToInteger("III"));
	//		  Output: 3

	// Example input: Console.WriteLine(RomanToInteger("LVIII"));
	//		  Output: 58

	// Example input: Console.WriteLine(RomanToInteger("MCMXCIV"));
	//		  Output: 1994

	internal class Program
	{
		private static int RomanToInteger(string roman)
		{
			int result = 0;
			Dictionary<char, int> romanValues = new Dictionary<char, int>
			{
				{'I', 1},
				{'V', 5},
				{'X', 10},
				{'L', 50},
				{'C', 100},
				{'D', 500},
				{'M', 1000}
			};
			for (int i = 0; i < roman.Length; i++)
			{
				if (i > 0 && romanValues[roman[i]] > romanValues[roman[i - 1]])
				{
					result += romanValues[roman[i]] - 2 * romanValues[roman[i - 1]];
				}
				else
				{
					result += romanValues[roman[i]];
				}
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(RomanToInteger("III"));
			Console.WriteLine(RomanToInteger("LVIII"));
			Console.WriteLine(RomanToInteger("MCMXCIV"));
		}
	}
}
