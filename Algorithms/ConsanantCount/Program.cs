namespace ConsanantCount
{
	// Write a function that counts the number of consonants in a given string.

	// Example Input: Console.WriteLine(ConsonantCount("Hello World"));
	//        Output: 7

	// Example Input: Console.WriteLine(ConsonantCount("Alphabets"));
	//        Output: 6

	internal class Program
	{
		private static int ConsanantCount(string data)
		{
			int count = 0;
			foreach (char item in data)
			{
				if ((item >= 65 && item <= 90) || (item >= 97 && item <= 122))
				{
					if (!(item == 'a' || item == 'e' || item == 'o' || item == 'u' || item == 'i' || item == 'ı' || item == 'ü' || item == 'ö' || item == 'A' || item == 'E' || item == 'O' || item == 'U' || item == 'İ' || item == 'I' || item == 'Ü' || item == 'Ö'))
					{
						count++;
					}
				}
			}
			return count;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(ConsanantCount("Hello World"));
			Console.WriteLine(ConsanantCount("Alphabets"));
		}
	}
}
