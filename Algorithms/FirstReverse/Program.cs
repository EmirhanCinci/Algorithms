namespace FirstReverse
{
	// Write a function that takes a string input from the user and returns the string reversed.

	// Example Input: Console.WriteLine(FirstReverse("I Love Code"));
	//        Output: edoC evoL I

	// Example Input: Console.WriteLine(FirstReverse("Hello World"));
	//        Output: dlroW olleH

	// Example Input: Console.WriteLine(FirstReverse("Emirhan CİNCİ"));
	//        Output: İCNİC nahrimE

	internal class Program
	{
		private static string FirstReverse(string data)
		{
			string result = "";
			for (int i = data.Length - 1; i >= 0; i--)
			{
				result += data[i];
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(FirstReverse("I Love Code"));
			Console.WriteLine(FirstReverse("Hello World"));
			Console.WriteLine(FirstReverse("Emirhan CİNCİ"));
		}
	}
}
