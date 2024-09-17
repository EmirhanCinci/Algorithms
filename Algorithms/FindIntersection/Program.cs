namespace FindIntersection
{
	// Write a function that takes an array of two strings as input.
	// The first string represents a list of comma-separated numbers sorted in ascending order,
	// and the second string represents a second list of comma-separated numbers.
	// The function should return a comma-separated string of numbers that appear in both lists,
	// sorted in ascending order. If there is no intersection, return "false".

	// Example Input: Console.WriteLine(FindIntersection(new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" }));
	//		  Output: 1 4 13

	// Example Input: Console.WriteLine(FindIntersection(new string[] { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" }));
	//	      Output: 1 9 10

	internal class Program
	{
		public static string FindIntersection(string[] arr)
		{
			string result = "";
			string[] first = arr[0].Split(',');
			string[] second = arr[1].Split(',');
			foreach (var b in first)
			{
				foreach (var i in second)
				{
					if (b == i)
					{
						result += b + " ";
					}
				}
			}
			if (result.Length > 0)
			{
				return result;
			}
			return "false";
		}

		static void Main(string[] args)
		{
			Console.WriteLine(FindIntersection(new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" }));
			Console.WriteLine(FindIntersection(new string[] { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" }));
		}
	}
}
