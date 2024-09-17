namespace FormattedDivision
{
	// Given two integers, num1 and num2, the program should return a string that represents the result of dividing num1 by num2 with 4 decimal places.

	// Example input: FormattedDivision(2, 3)
	//		  Output: 0.6667

	// Example input: FormattedDivision(123000, 7)
	//		  Output: 17571.4286

	internal class Program
	{
		public static string FormattedDivision(int num1, int num2)
		{
			double divide = (double)num1 / (double)num2;
			return String.Format("{0:n4}", divide);
		}

		static void Main(string[] args)
		{
			Console.WriteLine(FormattedDivision(2, 3));
			Console.WriteLine(FormattedDivision(123000, 7));
		}
	}
}
