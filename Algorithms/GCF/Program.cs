namespace GCF
{
	// Write a function that takes an array containing exactly two positive integers.
	// The function should return the greatest common factor (GCF) or greatest common divisor (GCD) of these two numbers.
	// The GCF/GCD is the largest number that divides both numbers without leaving a remainder.

	// Example Input: Console.WriteLine(GCF(new int[] {1, 6}));
	//		  Output: 1

	// Example Input: Console.WriteLine(GCF(new int[] {12, 28}));
	//		  Output: 4

	internal class Program
	{
		public static int GCF(int[] arr)
		{
			int ebob = 1;
			Array.Sort(arr);
			for (int i = 2; i <= arr[0]; i++)
			{
				if (arr[0] % i == 0 && arr[1] % i == 0)
				{
					ebob = i;
				}
			}
			return ebob;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(GCF(new int[] { 1, 6 }));
			Console.WriteLine(GCF(new int[] { 12, 28 }));
		}
	}
}
