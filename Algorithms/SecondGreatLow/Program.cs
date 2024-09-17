namespace SecondGreatLow
{
	// Write a function that takes an array of numbers and returns a string containing the second lowest and second highest numbers in the array,
	// separated by a space. The array will not be empty and will contain at least two numbers. If there are fewer than two unique numbers,
	// you should still handle it appropriately.

	// Example Input: Console.WriteLine(SecondGreatLow(new int[]{ 7, 7, 12, 98, 106 }));
	//        Output: 12 98

	// Example Input: Console.WriteLine(SecondGreatLow(new int[]{ 1, 42, 42, 180 }));
	//        Output: 42 42 

	// Example Input: Console.WriteLine(SecondGreatLow(new int[] { 4, 90 }));
	//        Output: 90 4

	internal class Program
	{
		public static string SecondGreatLow(int[] arr)
		{
			string result = "";
			Array.Sort(arr);
			if (arr.Length == 2)
			{
				if (arr[0] == arr[1])
				{
					return arr[0] + " " + arr[0];
				}
			}
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[0] != arr[i])
				{
					result += arr[i].ToString() + " ";
					break;
				}
			}
			for (int i = arr.Length - 2; i >= 0; i--)
			{
				if (arr[arr.Length - 1] != arr[i])
				{
					result += arr[i].ToString();
					break;
				}
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(SecondGreatLow(new int[] { 7, 7, 12, 98, 106 }));
			Console.WriteLine(SecondGreatLow(new int[] { 1, 42, 42, 180 }));
			Console.WriteLine(SecondGreatLow(new int[] { 4, 90 }));
		}
	}
}
