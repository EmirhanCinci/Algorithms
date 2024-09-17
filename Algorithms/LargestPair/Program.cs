namespace LargestPair
{
	// Write a function that takes an integer as input and determines the largest two-digit number
	// that can be formed from any pair of consecutive digits in that integer.
	// The input will always contain at least two positive digits.

	// Example Input: Console.WriteLine(LargestPair(4759472));
	//        Output: 94

	// Example Input: Console.WriteLine(LargestPair(453857));
	//        Output: 85

	// Example Input: Console.WriteLine(LargestPair(363223311));
	//        Output: 63

	internal class Program
	{
		public static int LargestPair(int number)
		{
			int max = 0;
			string data = number.ToString();
			for (int i = 0; i < data.Length - 1; i++)
			{
				string result = data[i].ToString() + data[i + 1].ToString();
				int k = Convert.ToInt32(result);
				if (k > max)
				{
					max = k;
				}
			}
			return max;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(LargestPair(4759472));
			Console.WriteLine(LargestPair(453857));
			Console.WriteLine(LargestPair(363223311));
		}
	}
}
