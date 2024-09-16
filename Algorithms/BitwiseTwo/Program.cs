namespace BitwiseTwo
{
	// The user inputs two binary numbers with equal length.
	// For each position, if both binary numbers have '1' at that position, '1' should be written; otherwise, '0' should be written.

	// Example Input: Console.WriteLine(BitwiseTwo(new String[] { "100", "000" }));
	//        Output: 000
	// Example Input: Console.WriteLine(BitwiseTwo(new String[] { "10100", "11100" }));
	//        Output: 10100
	// Example Input: Console.WriteLine(BitwiseTwo(new String[] { "10111", "01101" }));
	//        Output: 00101

	internal class Program
	{
		private static string BitwiseTwo(string[] arr)
		{
			string result = "";
			for (int i = 0; i < arr[0].Length; i++)
			{
				if (arr[0][i] == '1' && arr[1][i] == '1')
				{
					result += "1";
				}
				else
				{
					result += "0";
				}
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(BitwiseTwo(new String[] { "100", "000" }));
			Console.WriteLine(BitwiseTwo(new String[] { "10100", "11100" }));
			Console.WriteLine(BitwiseTwo(new String[] { "10111", "01101" }));
		}
	}
}
