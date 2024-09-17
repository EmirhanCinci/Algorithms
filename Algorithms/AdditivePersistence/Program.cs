namespace AdditivePersistence
{
	// Write a function that takes a positive integer num as input and calculates its digit sum persistence.
	// This means you repeatedly sum the digits of the number until you are left with a single digit.
	// The function should return this single digit result.

	// Example Input: Console.WriteLine(DigitSumPersistence(2718));
	//        Output: 9
	// Explanation: 2 + 7 + 1 + 8 = 18, then 1 + 8 = 9. The single digit result is 9.

	internal class Program
	{
		public static int DigitSum(int number)
		{
			int sum = 0;
			while (number > 0)
			{
				int k = number % 10;
				sum += k;
				number /= 10;
			}
			return sum;
		}

		public static int AdditivePersistence(int number)
		{
			int result = 0;
			if (number < 10)
			{
				return number;
			}
			while (number > 10)
			{
				result = DigitSum(number);
				number = result;
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(AdditivePersistence(2718));
		}
	}
}
