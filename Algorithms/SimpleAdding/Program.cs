namespace SimpleAdding
{
	// Write a function that calculates the sum of all numbers from 1 up to and including the given number 'num'.
	// For example, if the input is 4, the function should return 10 because 1 + 2 + 3 + 4 = 10.

	// Example Input: Console.WriteLine(SimpleAdding(4));
	//        Output: 10

	// Example Input: Console.WriteLine(SimpleAdding(10));
	//        Output: 55

	// Example Input: Console.WriteLine(SimpleAdding(20));
	//        Output: 210

	internal class Program
	{
		public static int SimpleAdding(int number)
		{
			return (number * (number + 1)) / 2;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(SimpleAdding(4));
			Console.WriteLine(SimpleAdding(10));
			Console.WriteLine(SimpleAdding(20));
		}
	}
}
