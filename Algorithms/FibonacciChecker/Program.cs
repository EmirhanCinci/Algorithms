namespace FibonacciChecker
{
	// Ensure that the function returns "yes" if the given number is a part of the Fibonacci sequence. 
	// The sequence is defined as: Fn = Fn-1 + Fn-2, where you add the previous two numbers to get Fn.
	// The first two numbers are 0 and 1, followed by 1, 2, 3, 5, and so on. 
	// If the number is not in the Fibonacci sequence, return "no".
	// Fibonacci Numbers: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89...

	// Example input: FibonacciChecker(34);
	//		  Output: yes

	// Example input: FibonacciChecker(54);
	//		  Output: no

	internal class Program
	{
		private static string FibonacciChecker(int number)
		{
			string result = "no";
			int[] arr = new int[3] { 0, 1, 1 };
			while (arr[2] < number)
			{
				arr[0] = arr[1];
				arr[1] = arr[2];
				arr[2] = arr[0] + arr[1];
			}
			if (number == arr[2] || number == 0 || number == 1)
			{
				result = "yes";
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(FibonacciChecker(34));
			Console.WriteLine(FibonacciChecker(54));
		}
	}
}
