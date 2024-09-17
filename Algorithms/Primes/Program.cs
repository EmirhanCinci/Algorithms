namespace Primes
{
	// Ensure that the function takes the given num parameter and returns the string "true" if the parameter is a prime number, otherwise return the string "false".
	// The range will be between 1 and 2^16.

	// Example input: 4
	//		  Output: false

	// Example input: 1709
	//		  Output: true

	internal class Program
	{
		public static bool Primes(int number)
		{
			if (number <= 1)
			{
				return false;
			}
			else
			{
				for (int i = 2; i <= Math.Sqrt(number); i++)
				{
					if (number % i == 0)
					{
						return false;
					}
				}
			}
			return true;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(Primes(4));
			Console.WriteLine(Primes(1709));
		}
	}
}
