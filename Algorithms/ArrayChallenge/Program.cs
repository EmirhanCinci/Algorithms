namespace ArrayChallenge
{
	// Write a function that takes an array of numbers and determines if any combination of numbers
	// (excluding the largest number) can be summed to equal the largest number in the array.
	// If a valid combination exists, return "true"; otherwise, return "false".

	// Example Input: Console.WriteLine(ArrayChallenge(new int[] { 5, 7, 16, 1, 2 }));
	//        Output: false

	// Example Input: Console.WriteLine(ArrayChallenge(new int[] { 3, 5, -1, 8, 12 }));
	//        Output: true

	// Example Input: Console.WriteLine(ArrayChallenge(new int[] { 4, 6, 23, 10, 1, 3 }));
	//        Output: true

	internal class Program
	{
		public static bool ArrayChallenge(int[] arr)
		{
			Array.Sort(arr);
			int sum = 0;
			int max = arr[arr.Length - 1];
			for (int i = 0; i < arr.Length - 1; i++)
			{
				if (arr[i] == arr[i + 1])
				{
					return false;
				}
				sum += arr[i];
			}
			return (sum >= max);
		}

		static void Main(string[] args)
		{
			Console.WriteLine(ArrayChallenge(new int[] { 5, 7, 16, 1, 2 }));
			Console.WriteLine(ArrayChallenge(new int[] { 3, 5, -1, 8, 12 }));
			Console.WriteLine(ArrayChallenge(new int[] { 4, 6, 23, 10, 1, 3 }));
		}
	}
}
