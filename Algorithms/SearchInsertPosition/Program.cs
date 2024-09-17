namespace SearchInsertPosition
{
	// Given a sorted array of distinct integers and a target value, return the index of the target if found.
	// If the target is not found, return the index where it would be inserted in order.
	// You need to write an algorithm with a time complexity of O(log n).

	// Example input: Console.WriteLine(SearchInsertPosition(new int[] { 1, 3, 5, 6 }, 5));
	//		  Output: 2

	// Example input: Console.WriteLine(SearchInsertPosition(new int[] { 1, 3, 5, 6 }, 2));
	//		  Output: 1

	// Example input: Console.WriteLine(SearchInsertPosition(new int[] { 1, 3, 5, 6 }, 7));
	//		  Output: 4

	internal class Program
	{
		private static int SearchInsertPosition(int[] arr, int x)
		{
			int left = 0;
			int right = arr.Length - 1;
			while (left <= right)
			{
				int mid = (left + right) / 2;

				if (arr[mid] == x)
				{
					return mid;
				}
				else if (arr[mid] < x)
				{
					left = mid + 1;
				}
				else
				{
					right = mid - 1;
				}
			}
			return left;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(SearchInsertPosition(new int[] { 1, 3, 5, 6 }, 5));
			Console.WriteLine(SearchInsertPosition(new int[] { 1, 3, 5, 6 }, 2));
			Console.WriteLine(SearchInsertPosition(new int[] { 1, 3, 5, 6 }, 7));
		}
	}
}
