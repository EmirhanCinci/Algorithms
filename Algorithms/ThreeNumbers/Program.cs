namespace ThreeNumbers
{
	// Write a function that takes a string parameter str and checks if every word in the string contains exactly three unique single-digit integers.
	// The integers can appear anywhere within the word but cannot be adjacent to each other.
	// The function should return true if every word in the string contains exactly three unique single-digit integers, otherwise return false.

	// Example Input: Console.WriteLine("2a3b5 w1o2r13d g1gg92");
	//		  Output: true
	// Explanation: The first word "2a3b5" contains unique digits 2, 3, and 5. The second word "w1o2r13d" contains unique digits 1, 2, and 3. The third word "g1gg92" contains unique digits 1, 9, and 2.

	// Example Input: Console.WriteLine("21aa3a ggg4g4g6ggg");
	//		  Output: false
	// Explanation: The first word "21aa3a" does not contain exactly three unique digits as the digits are adjacent. The second word "ggg4g4g6ggg" does not meet the requirement either.

	internal class Program
	{
		public static bool ThreeNumbers(string txt)
		{
			string[] words = txt.Split(' ');
			foreach (var item in words)
			{
				HashSet<char> list = new HashSet<char>();
				for (int i = 0; i < item.Length; i++)
				{
					if (char.IsNumber(item[i]) && item[i] != item[item.Length - 1] && item[i] != item[item.Length - 2])
					{
						if (char.IsNumber(item[i + 1]) && char.IsNumber(item[i + 2]))
						{
							return false;
						}
					}
					if (char.IsNumber(item[i]))
					{
						list.Add(item[i]);
					}
				}
				if (list.Count != 3)
				{
					return false;
				}
				list.Clear();
			}
			return true;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(ThreeNumbers("2a3b5 w1o2r13d g1gg92"));
			Console.WriteLine(ThreeNumbers("21aa3a ggg4g4g6ggg"));
		}
	}
}
