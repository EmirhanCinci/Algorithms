namespace ThreeFiveMultiples
{
	// Ensure that the function returns the sum of all multiples of 3 and 5 that are below the given number.
	// For example: if num is 10, the multiples of 3 and 5 below 10 are 3, 5, 6, and 9. Their sum is 23, so the program should return 23.

	// Example input: 6
	//		  Output: 8

	// Example input: 1
	//		  Output: 0

	internal class Program
	{
		public static int ThreeFiveMultiples(int sayi)
		{
			int toplam = 0;
			for (int i = 1; i < sayi; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					toplam += i;
				}
			}
			return toplam;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(ThreeFiveMultiples(6));
			Console.WriteLine(ThreeFiveMultiples(1));
		}
	}
}
