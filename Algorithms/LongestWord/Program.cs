namespace LongestWord
{
	// Write a function that takes a string as input and returns the longest word in the string.
	// If there are multiple words of the same maximum length, return the first one.
	// Ignore punctuation and assume the string will not be empty. Words can also include numbers.

	// Example Input: Console.WriteLine(LongestWord("fun&!! time"));
	//        Output: time

	// Example Input: Console.WriteLine(LongestWord("I love dogs"));
	//        Output: love

	internal class Program
	{
		public static string LettersAndNumbers(string data)
		{
			string result = "";
			data = data.ToLower();
			for (int i = 0; i < data.Length; i++)
			{
				if ((data[i] >= 0 && data[i] <= 9) || (data[i] >= 97 && data[i] <= 122) || data[i] == ' ')
				{
					result += data[i];
				}
			}
			return result;
		}

		public static string LongestWord(string data)
		{
			data = LettersAndNumbers(data);
			string[] arr = data.Split(' ');
			string result = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i].Length > result.Length)
				{
					result = arr[i];
				}
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(LongestWord("fun&!! time"));
			Console.WriteLine(LongestWord("I love dogs"));
		}
	}
}
