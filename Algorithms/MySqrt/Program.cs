namespace MySqrt
{
	// Given a non-negative integer x, return the nearest integer to the square root of x rounded down.
	// The returned integer must also be non-negative.

	// Example input: Console.WriteLine(MySqrt(4));
	//		  Output: 2

	// Example input: Console.WriteLine(MySqrt(52));
	//		  Output: 7

	// Example input: Console.WriteLine(MySqrt(168));
	//		  Output: 12

	internal class Program
	{
		private static int MySqrt(int number)
		{
			double test = number / 2.0;
			double error = 0.01;
			double result = 0;
			while (true)
			{
				result = (test + (number / test)) / 2;
				if (Math.Abs(result - test) < error)
				{
					break;
				}
				test = result;
			}
			return (int)Math.Floor(result);
		}

		static void Main(string[] args)
		{
			Console.WriteLine(MySqrt(4));
			Console.WriteLine(MySqrt(52));
			Console.WriteLine(MySqrt(168));
		}
	}
}
