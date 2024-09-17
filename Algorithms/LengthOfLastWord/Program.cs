namespace LengthOfLastWord
{
	// Given a string consisting of words and spaces, return the length of the last word in the string.

	// Example input: Console.WriteLine(LengthOfLastWord("Hello World"));
	//		  Output: 5

	// Example input: Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
	//		  Output: 4

	// Example input: Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));
	//		  Output: 6

	internal class Program
	{
		private static int LengthOfLastWord(string data)
		{
			data = data.Trim();
			string[] list = data.Split(' ');
			return list[list.Length - 1].Length;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(LengthOfLastWord("Hello World"));
			Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
			Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));
		}
	}
}
