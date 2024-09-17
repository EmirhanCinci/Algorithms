namespace MeanMode
{
	// Write a function that takes an array of positive integers and checks if the mode of the array 
	// (the most frequent number) is equal to the mean (average) of the array.
	// If they are equal, return 1; if not, return 0.
	// The array will always have at least one element, will contain only positive integers, 
	// and there will be only one mode in the array.

	// Example Input: Console.WriteLine(MeanMode(new int[] { 1, 2, 3 }));
	//        Output: 0

	// Example Input: Console.WriteLine(MeanMode(new int[] { 4, 4, 4, 6, 2 }));
	//        Output: 1

	// Example Input: Console.WriteLine(MeanMode(new int[] { 5, 3, 3, 3, 1 }));
	//        Output: 1

	internal class Program
	{
		public static int Avg(int[] arr)
		{
			int sum = 0;
			foreach (var item in arr)
			{
				sum += item;
			}
			return sum / arr.Length;
		}

		public static int Mode(int[] arr)
		{
			int max = 0;
			int mode = 0;
			int count = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length; j++)
				{
					if (arr[i] == arr[j])
					{
						count++;
					}
				}
				if (count > max)
				{
					max = count;
					mode = i;
				}
				count = 0;
			}
			return arr[mode];
		}

		public static int MeanMode(int[] arr)
		{
			if (Avg(arr) == Mode(arr))
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine(MeanMode(new int[] { 1, 2, 3 }));
			Console.WriteLine(MeanMode(new int[] { 4, 4, 4, 6, 2 }));
			Console.WriteLine(MeanMode(new int[] { 5, 3, 3, 3, 1 }));
		}
	}
}
