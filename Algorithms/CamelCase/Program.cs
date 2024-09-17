namespace CamelCase
{
	// Write a function that returns the input string in camelCase format,
	// where the first letter of each word (except the first word) is capitalized and all other letters are lowercase.
	// The string will only contain letters and punctuation marks as delimiters between words.

	// Example Input: Console.WriteLine(CamelCase("BOB loves-coding"));
	//        Output: bobLovesCoding

	// Example Input: Console.WriteLine(CamelCase("cats AND*Dogs-are Awesome"));
	//        Output: catsAndDogsAreAwesome

	// Example Input: Console.WriteLine(CamelCase("a b c d-e-f%g"));
	//        Output: aBCDEFG

	internal class Program
	{
		private static string CamelCase(string data)
		{
			string result = "";
			data = data.ToLower();
			for (int i = 0; i < data.Length; i++)
			{
				if (data[i] < 97 || data[i] > 122)
				{
					result += " ";
				}
				else if (i != 0 && result[result.Length - 1] == ' ')
				{
					result += data[i].ToString().ToUpper();
				}
				else
				{
					result += data[i];
				}
			}
			result = result.Replace(" ", "");
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(CamelCase("BOB loves-coding"));
			Console.WriteLine(CamelCase("cats AND*Dogs-are Awesome"));
			Console.WriteLine(CamelCase("a b c d-e-f%g"));
		}
	}
}
