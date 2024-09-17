namespace NumberReverse
{
	// Write a function that takes an array of numbers as a parameter (in string format) 
	// and returns a new string where the numbers are in reverse order.

	// Example Input: Console.WriteLine(NumberReverse(new string[]{ "1", "2", "3" }));
	//        Output: 3 2 1

	// Example Input: Console.WriteLine(NumberReverse(new string[]{ "10", "20", "50" }));
	//        Output: 50 20 10

	internal class Program
	{
		private static string NumberReverse(string[] arr)
		{
			string result = "";
			Array.Reverse(arr);
			foreach (string s in arr)
			{
				result += s + " ";
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(NumberReverse(new string[] { "1", "2", "3" }));
			Console.WriteLine(NumberReverse(new string[] { "10", "20", "50" }));
		}
	}
}
