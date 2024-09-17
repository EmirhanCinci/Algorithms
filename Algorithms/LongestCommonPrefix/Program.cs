namespace LongestCommonPrefix
{
	// Find the longest common prefix in a given array of strings.

	// Example input: Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
	//		  Output: "fl"

	// Example input: Console.WriteLine(LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
	//		  Output: ""

	// Example input: Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "flowers" }));
	//		  Output: "flow"

	internal class Program
	{
		private static string LongestCommonPrefix(string[] arr)
		{
			string result = "";
			arr = arr.OrderBy(x => x.Length).ToArray();
			for (int i = 0; i < arr[0].Length; i++)
			{
				int count = 0;
				for (int j = 1; j < arr.Length; j++)
				{
					if (arr[0][i] == arr[j][i])
					{
						count++;
					}
				}
				if (count == arr.Length - 1)
				{
					result += arr[0][i];
					count = 0;
				}
				else
				{
					return result;
				}
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
			Console.WriteLine(LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
			Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "flowers" }));
		}
	}
}
