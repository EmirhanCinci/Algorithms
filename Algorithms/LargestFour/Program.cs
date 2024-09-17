namespace LargestFour
{
	// Write a function that takes an array of integers and returns the sum of the four largest elements in the array.
	// For example, if the array is [4, 5, -2, 3, 1, 2, 6, 6], the four largest elements are 6, 6, 5, and 4, and their sum is 21.
	// Therefore, the function should return 21.

	// Example Input: Console.WriteLine(LargestFour(new int[] { 1, 1, 1, -5 }));
	//        Output: -2

	// Example Input: Console.WriteLine(LargestFour(new int[] { 0, 0, 2, 3, 7, 1 }));
	//        Output: 13

	internal class Program
	{
		public static int LargestFour(int[] arr)
		{
			int sum = 0;
			if (arr.Length <= 4)
			{
				foreach (var item in arr)
				{
					sum += item;
				}
				return sum;
			}
			Array.Sort(arr);
			for (int i = arr.Length - 1; i >= arr.Length - 4; i--)
			{
				sum += arr[i];
			}
			return sum;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(LargestFour(new int[] { 1, 1, 1, -5 }));
			Console.WriteLine(LargestFour(new int[] { 0, 0, 2, 3, 7, 1 }));
		}
	}
}
