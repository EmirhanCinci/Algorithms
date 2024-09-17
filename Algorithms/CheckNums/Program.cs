namespace CheckNums
{
	// Write a function that takes two numbers (num1 and num2) and compares them.
	// If num1 is greater than num2, print false; 
	// If num2 is greater than num1, print true; 
	// If they are equal, print -1.

	// Example Input: Console.WriteLine(CheckNums(11, 26));
	//        Output: true

	// Example Input: Console.WriteLine(CheckNums(21, 2));
	//        Output: false

	// Example Input: Console.WriteLine(CheckNums(25, 25));
	//        Output: -1

	internal class Program
	{
		private static string CheckNums(int number1, int number2)
		{
			if (number1 == number2)
			{
				return "-1";
			}
			else if (number1 > number2)
			{
				return "false";
			}
			else
			{
				return "true";
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine(CheckNums(11, 26));
			Console.WriteLine(CheckNums(21, 2));
			Console.WriteLine(CheckNums(25, 25));
		}
	}
}
