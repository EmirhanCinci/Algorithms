namespace BitwiseOne
{
	// Write a function that takes an array of two binary strings of equal length.
	// Perform a bitwise OR operation on the two binary strings.
	// The bitwise OR operation will place a 0 in the result string if both bits are 0,
	// otherwise, it will place a 1 if either bit is 1.

	// Example Input: Console.WriteLine(BitwiseOne(new string[] { "1001", "0100" }));
	//		  Output: 1101

	// Example Input: Console.WriteLine(BitwiseOne(new string[] { "100", "000" }));
	//		  Output: 100

	// Example Input: Console.WriteLine(BitwiseOne(new string[] { "00011", "01010" }));
	//        Output: 01011

	internal class Program
	{
		public static string BitwiseOne(string[] arr)
		{
			string result = "";
			for (int i = 0; i < arr[0].Length; i++)
			{
				if (arr[0][i] == '1' || arr[1][i] == '1')
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
			Console.WriteLine(BitwiseOne(new string[] { "1001", "0100" }));
			Console.WriteLine(BitwiseOne(new string[] { "100", "000" }));
			Console.WriteLine(BitwiseOne(new string[] { "00011", "01010" }));
		}
	}
}
