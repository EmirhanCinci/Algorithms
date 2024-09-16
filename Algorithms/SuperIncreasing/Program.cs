namespace SuperIncreasing
{
	// Take an array of positive integers from the user.
	// Determine whether the array forms a super-increasing sequence, where each element is greater than the sum of all previous elements in the array.

	// Example Input: Console.WriteLine(SuperIncreasing(new int[] { 1, 2, 3, 4 }));
	//        Output: false

	// Example Input: Console.WriteLine(SuperIncreasing(new int[] { 1, 2, 5, 10 }));
	//        Output: true

	// Example Input: Console.WriteLine(SuperIncreasing(new int[] { 1, 3, 6, 13, 54 }));
	//        Output: true

	internal class Program
	{
		private static bool SuperIncreasing(int[] arr)
		{
			bool result = true;
			int sum = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				if (sum >= arr[i])
				{
					return false;
				}
				sum += arr[i];
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(SuperIncreasing(new int[] { 1, 2, 3, 4 }));
			Console.WriteLine(SuperIncreasing(new int[] { 1, 2, 5, 10 }));
			Console.WriteLine(SuperIncreasing(new int[] { 1, 3, 6, 13, 54 }));
		}
	}
}
