namespace FizzBuzz
{
	// A positive integer is taken from the user.
	// Then, starting from 1 and incrementing by 1 up to the entered positive integer, control operations are performed.
	// If the number is divisible by 3, "Fizz" is printed; if the number is divisible by 5, "Buzz" is printed; if the number is divisible by both 3 and 5, "FizzBuzz" is printed.
	// If none of these conditions are met, the number itself is printed.

	// Example Input: Console.WriteLine(FizzBuzz(12));
	//        Output: 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz

	// Example Input: Console.WriteLine(FizzBuzz(16));
	//        Output: 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16

	// Example Input: Console.WriteLine(FizzBuzz(32));
	//        Output: 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32

	internal class Program
	{
		private static string FizzBuzz(int number)
		{
			string result = "";
			for (int i = 1; i <= number; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					result += "FizzBuzz ";
				}
				else if (i % 3 == 0 && i % 5 != 0)
				{
					result += "Fizz ";
				}
				else if (i % 3 != 0 && i % 5 == 0)
				{
					result += "Buzz ";
				}
				else
				{
					result += i.ToString() + " ";
				}
			}
			result = result.TrimEnd();
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(FizzBuzz(12));
			Console.WriteLine(FizzBuzz(16));
			Console.WriteLine(FizzBuzz(32));
		}
	}
}
