namespace PowerSetCount
{
	// Write a function that calculates the number of subsets that can be created from a given array.
	// The formula to calculate the number of subsets is -----> 2 ^ (number of elements in the array)

	// Example Input: Console.WriteLine(PowerSetCount(new int[]{ 1, 2, 3, 4 }));
	//        Output: 16

	// Example Input: Console.WriteLine(PowerSetCount(new int[]{ 5, 6 }));
	//        Output: 4

	internal class Program
	{
		private static int PowerSetCount(int[] arr)
		{
			return (int)Math.Pow(2, arr.Length);
		}

		static void Main(string[] args)
		{
			Console.WriteLine(PowerSetCount(new int[] { 1, 2, 3, 4 }));
			Console.WriteLine(PowerSetCount(new int[] { 5, 6 }));
		}
	}
}
