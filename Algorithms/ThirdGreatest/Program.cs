namespace ThirdGreatest
{
	// Write a function that takes an array of strings, strArr, and returns the third largest word based on the number of characters in each word.
	// If there are multiple words with the same length, consider the last occurrence of that length.
	// The function should handle cases where there are not enough distinct lengths and return the last of the words with the third largest length.

	// Example Input: Console.WriteLine(ThirdGreatest(new string[] { "hello", "world", "before", "all" }));
	//		  Output: world
	// Explanation: "before" is the longest word with 6 characters. "hello" and "world" are both 5 characters long, but "world" is the last 5-letter word in the array.

	// Example Input: Console.WriteLine(ThirdGreatest(new string[] { "hello", "world", "after", "all" }));
	//		  Output: after
	// Explanation: The words "hello", "world", and "after" are all 5 characters long. Since "after" is the last one with this length, it is the output.

	// Example Input: Console.WriteLine(ThirdGreatest(new string[] { "coder", "byte", "code" }));
	//		  Output: code
	// Explanation: The longest words are "coder" (5 characters) and "code" (4 characters). "code" is the last word with the third largest length (4 characters).

	// Example Input: Console.WriteLine(ThirdGreatest(new string[] { "abc", "defg", "z", "hijk" }));
	//		  Output: abc
	// Explanation: The words are "abc" (3 characters), "defg" (4 characters), "z" (1 character), and "hijk" (4 characters). Since "defg" and "hijk" are both 4 characters long, the last 3-character word is "abc".

	internal class Program
	{
		public static string ThirdGreatest(string[] arr)
		{
			string[] result = arr.OrderByDescending(x => x.Length).ToArray();
			return result[2];
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Sonuç: " + ThirdGreatest(new string[] { "hello", "world", "before", "all" }));
			Console.WriteLine("Sonuç: " + ThirdGreatest(new string[] { "hello", "world", "after", "all" }));
			Console.WriteLine("Sonuç: " + ThirdGreatest(new string[] { "coder", "byte", "code" }));
			Console.WriteLine("Sonuç: " + ThirdGreatest(new string[] { "abc", "defg", "z", "hijk" }));
		}
	}
}
