namespace AlphabetSoup
{
	// Ensure that the function takes the provided string parameter and returns the string with its letters sorted in alphabetical order.
	// Assume that numbers and punctuation marks are not included in the processing.

	// Example Input: Console.WriteLine(AlphabetSoup("coderbyte"));
	//        Output: bcdeeorty

	// Example Input: Console.WriteLine(AlphabetSoup("hooplah"));
	//        Output: ahhloop

	internal class Program
	{
		private static string AlphabetSoup(string data)
		{
			string result = "";
			char[] chars = data.ToCharArray();
			Array.Sort(chars);
			foreach (char c in chars)
			{
				result += c;
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(AlphabetSoup("coderbyte"));
			Console.WriteLine(AlphabetSoup("hooplah"));
		}
	}
}
