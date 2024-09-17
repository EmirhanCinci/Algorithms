namespace WordCount
{
	// Write a function that takes a string parameter, str, and performs the following tasks:
	// 1. Count the number of words in the string.
	// 2. Words are separated by a single space.

	// Example Input: Console.WriteLine(WordCount("Hello World"));
	//		  Output: 2
	// Explanation: The string contains 2 words: "Hello" and "World".

	// Example Input: Console.WriteLine(WordCount("one 22 three"));
	//		  Output: 3
	// Explanation: The string contains 3 words: "one", "22", and "three".


	internal class Program
	{
		public static int WordCount(string txt)
		{
			string[] word = txt.Split(' ');
			return word.Length;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(WordCount("Hello World"));
			Console.WriteLine(WordCount("one 22 three"));
		}
	}
}
