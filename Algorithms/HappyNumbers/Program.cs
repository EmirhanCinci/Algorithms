namespace HappyNumbers
{
	// Write a function that determines if a given positive integer is a happy number.
	// A happy number is defined as a number where the sum of the squares of its digits eventually equals 1.
	// If the sum equals 1, it is a happy number; otherwise, it is not.

	// Example: Let's analyze the number 10 -----> 1^2 + 0^2 = 1 + 0 = 1, so it is a happy number.

	// Example Input: Console.WriteLine(HappyNumbers(1));
	//        Output: true

	// Example Input: Console.WriteLine(HappyNumbers(10));
	//        Output: true

	// Example Input: Console.WriteLine(HappyNumbers(101));
	//        Output: false

	internal class Program
	{
		private static bool HappyNumbers(int number)
		{
			int sum = 0;
			while (number > 0)
			{
				sum += (int)Math.Pow(number % 10, 2);
				number /= 10;
			}
			if (sum == 1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine(HappyNumbers(1));
			Console.WriteLine(HappyNumbers(10));
			Console.WriteLine(HappyNumbers(101));
		}
	}
}
