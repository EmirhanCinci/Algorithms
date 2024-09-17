namespace PowerOfTwo
{
	// Write a function that determines if a given positive integer is a power of 2.

	// Example Input: Console.WriteLine(PowerOfTwo(16));
	//        Output: true

	// Example Input: Console.WriteLine(PowerOfTwo(1));
	//        Output: true

	// Example Input: Console.WriteLine(PowerOfTwo(124));
	//        Output: false

	internal class Program
	{
		private static bool PowerOfTwo(int number)
		{
			if (number == 1)
			{
				return true;
			}
			if (number % 2 != 0 || number == 0)
			{
				return false;
			}
			return PowerOfTwo(number / 2);
		}

		static void Main(string[] args)
		{
			Console.WriteLine(PowerOfTwo(16));
			Console.WriteLine(PowerOfTwo(1));
			Console.WriteLine(PowerOfTwo(124));
		}
	}
}
