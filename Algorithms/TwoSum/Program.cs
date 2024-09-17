namespace TwoSum
{
	// Write a function that, given an integer array, prints all pairs of numbers (except the first element) 
	// whose sum equals the first element of the array. 
	// If no such pairs exist, the function should return -1.

	// Example Input: Console.WriteLine(TwoSum(new int[] { 17, 4, 5, 6, 10, 11, 4, -3, -5, 3, 15, 2, 7 }));
	//        Output: (6, 11)  (10, 7)  (15, 2)

	// Example Input: Console.WriteLine(TwoSum(new int[] { 7, 6, 4, 1, 7, -2, 3, 12 }));
	//        Output: (6, 1)  (4, 3)

	// Example Input: Console.WriteLine(TwoSum(new int[] { 17, 4, 5, 6 }));
	//        Output: -1

	internal class Program
	{
		private static string TwoSum(int[] arr)
		{
			string result = "";
			for (int i = 1; i < arr.Length - 1; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[j] + arr[i] == arr[0])
					{
						result += "(" + arr[i] + ", " + arr[j] + ") ";
					}
				}
			}
			if (result.Length == 0)
			{
				return "-1";
			}
			else
			{
				return result;
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine(TwoSum(new int[] { 17, 4, 5, 6, 10, 11, 4, -3, -5, 3, 15, 2, 7 }));
			Console.WriteLine(TwoSum(new int[] { 7, 6, 4, 1, 7, -2, 3, 12 }));
			Console.WriteLine(TwoSum(new int[] { 17, 4, 5, 6 }));
		}
	}
}
