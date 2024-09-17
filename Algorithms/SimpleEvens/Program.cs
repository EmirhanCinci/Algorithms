namespace SimpleEvens
{
	// Write a function that checks whether all the digits in a given positive integer are even numbers.

	// Example Input: Console.WriteLine(SimpleEvens(4602225));
	//        Output: false

	// Example Input: Console.WriteLine(SimpleEvens(226486));
	//        Output: true

	// Example Input: Console.WriteLine(SimpleEvens(2645846));
	//        Output: false

	internal class Program
	{
		private static bool SimpleEvens(int number)
		{
			string data = number.ToString();
			foreach (char c in data)
			{
				if (Convert.ToInt32(c) % 2 != 0)
				{
					return false;
				}
			}
			return true;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(SimpleEvens(4602225));
			Console.WriteLine(SimpleEvens(226486));
			Console.WriteLine(SimpleEvens(2645846));
		}
	}
}
