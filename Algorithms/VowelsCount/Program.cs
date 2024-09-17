namespace VowelsCount
{
	// Write a function that takes a string as input and returns the number of vowel characters in the string.
	// The vowels to consider are 'a', 'e', 'i', 'o', 'u' (both uppercase and lowercase).

	// Example Input: Console.WriteLine(VowelCount("hello"));
	//	      Output: 2

	// Example Input: Console.WriteLine(VowelCount("coderbyte"));
	//		  Output: 3

	internal class Program
	{
		public static int VowelsCount(string txt)
		{
			int vowel = 0;
			char[] vowelLetters = { 'A', 'E', 'I', 'O', 'U', 'Ö', 'İ', 'Ü', 'a', 'e', 'ı', 'o', 'u', 'ö', 'i', 'ü' };
			for (int i = 0; i < txt.Length; i++)
			{
				if (vowelLetters.Contains(txt[i]))
				{
					vowel++;
				}
			}
			return vowel;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(VowelsCount("hello"));
			Console.WriteLine(VowelsCount("coderbyte"));
		}
	}
}
