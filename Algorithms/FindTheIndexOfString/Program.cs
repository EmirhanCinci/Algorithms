namespace FindTheIndexOfString
{
	// A method to determine the index at which a given letter or word starts within a given string.

	// Example input: Console.WriteLine(FindTheIndexOfString("sadbutsad", "sad"));
	//		  Output: 0

	// Example input: Console.WriteLine(FindTheIndexOfString("leetcode", "leeto"));
	//		  Output: -1

	internal class Program
	{
		private static int FindTheIndexOfString(string data, string needle)
		{
			return data.IndexOf(needle);
		}

		static void Main(string[] args)
		{
			Console.WriteLine(FindTheIndexOfString("sadbutsad", "sad"));
			Console.WriteLine(FindTheIndexOfString("leetcode", "leeto"));
		}
	}
}
