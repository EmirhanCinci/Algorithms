using System.Text.RegularExpressions;

namespace NumberAddition
{
	// Write a function that takes a string parameter, str, and performs the following tasks:
	// 1. Find all the numbers within the string.
	// 2. Sum these numbers.
	// 3. Return the final sum.

	// Example Input: Console.WriteLine(NumberAddition("75Number9"));
	//		  Output: 84
	// Explanation: The numbers found in the string are 75 and 9. Their sum is 84.

	// Example Input: Console.WriteLine(NumberAddition("10 2One Number*1*"));
	//		  Output: 13
	// Explanation: The numbers found in the string are 10, 2, and 1. Their sum is 13.

	internal class Program
	{
		public static int NumberAddition(string txt)
		{
			int sum = 0;
			string[] numbers = Regex.Split(txt, @"\D+");
			foreach (string item in numbers)
			{
				if (!string.IsNullOrEmpty(item))
				{
					sum += Convert.ToInt32(item);
				}
			}
			return sum;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(NumberAddition("75Number9"));
			Console.WriteLine(NumberAddition("10 2One Number*1*"));
		}
	}
}
