namespace SnakeCase
{
	// Write a function that returns the input string in snake_case format,
	// where each word is written in lowercase and words are separated by underscores.
	// The string will only contain letters and a few punctuation marks as delimiters between words.

	// Example Input: Console.WriteLine(SnakeCase("cats AND*Dogs-are Awesome"));
	//        Output: cats_and_dogs_are_awesome

	// Example Input: Console.WriteLine(SnakeCase("a b c d-e-f%g"));
	//        Output: a_b_c_d_e_f_g

	// Example Input: Console.WriteLine(SnakeCase("BOB loves-coding"));
	//        Output: bob_loves_coding

	internal class Program
	{
		private static string SnakeCase(string data)
		{
			string result = "";
			data = data.ToLower();
			foreach (char c in data)
			{
				if (c >= 97 && c <= 122)
				{
					result += c;
				}
				else
				{
					result += "_";
				}
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(SnakeCase("cats AND*Dogs-are Awesome"));
			Console.WriteLine(SnakeCase("a b c d-e-f%g"));
			Console.WriteLine(SnakeCase("BOB loves-coding"));
		}
	}
}
