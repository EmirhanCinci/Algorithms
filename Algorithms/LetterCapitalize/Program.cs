namespace LetterCapitalize
{
	// Write a function that takes a string and capitalizes the first letter of each word.
	// The words in the string will be separated by a single space.

	// Example Input: Console.WriteLine(LetterCapitalize("hello world"));
	//        Output: Hello World

	// Example Input: Console.WriteLine(LetterCapitalize("merhaBa HERKESE"));
	//        Output: Merhaba Herkese

	internal class Program
	{
		private static string LetterCapitalize(string data)
		{
			string result = "";
			data = data.ToLower();
			for (int i = 0; i < data.Length; i++)
			{
				if (i == 0)
				{
					result += data[i].ToString().ToUpper();
				}
				else if (data[i] == ' ')
				{
					result += " " + data[i + 1].ToString().ToUpper();
					i++;
				}
				else
				{
					result += data[i].ToString().ToLower();
				}
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(LetterCapitalize("hello world"));
			Console.WriteLine(LetterCapitalize("merhaBa HERKESE"));
		}
	}
}
