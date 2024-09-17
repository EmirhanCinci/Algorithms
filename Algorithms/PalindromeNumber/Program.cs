namespace PalindromeNumber
{
	// Palindromic numbers are numbers that remain the same when reversed. 
	// Write a method to determine whether a given number is a palindromic number.

	// Example input: Console.WriteLine(PalindromeNumber(121));
	//		  Output: true

	// Example input: Console.WriteLine(PalindromeNumber(-121));
	//		  Output: false

	// Example input: Console.WriteLine(PalindromeNumber(10));
	//		  Output: false

	internal class Program
	{
		public static bool PalindromeNumber(int number)
		{
			if (number < 0)
			{
				return false;
			}

			int originalNumber = number;
			int reversedNumber = 0;

			while (number > 0)
			{
				int digit = number % 10;
				reversedNumber = (reversedNumber * 10) + digit;
				number /= 10;
			}

			return originalNumber == reversedNumber;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(PalindromeNumber(121));
			Console.WriteLine(PalindromeNumber(-121));
			Console.WriteLine(PalindromeNumber(10));
		}
	}
}
