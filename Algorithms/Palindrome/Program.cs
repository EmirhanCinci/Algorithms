namespace Palindrome
{
	// A palindrome is a word, phrase, number, or other sequence of characters that reads the same backward as forward.
	// Write a function that determines if the given input string is a palindrome or not.

	// Example Input: Console.WriteLine(Palindrome("never odd or even"));
	//        Output: true

	// Example Input: Console.WriteLine(Palindrome("eye"));
	//        Output: true

	internal class Program
	{
		private static bool Palindrome(string data)
		{
			string output = "";
			data = data.Replace(" ", "");
			for (int i = data.Length - 1; i >= 0; i--)
			{
				output += data[i];
			}
			if (data == output)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine(Palindrome("never odd or even"));
			Console.WriteLine(Palindrome("eye"));
		}
	}
}
