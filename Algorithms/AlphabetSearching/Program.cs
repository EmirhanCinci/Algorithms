namespace AlphabetSearching
{
	// Take a string input from the user.
	// Check if the string contains every letter of the English alphabet.
	// Print `true` if all letters are present; otherwise, print `false` to the console.

	// Example Input: Console.WriteLine(AlphabetSearching("zacxyjbbkfgtbhdaielqrm45pnsowtuv"));
	//        Output: true

	// Example Input: Console.WriteLine(AlphabetSearching("abcdefghijklmnopqrstuvwxyyyy"));
	//        Output: false

	// Example Input: Console.WriteLine(AlphabetSearching("abc123456kmo"));
	//        Output: false

	internal class Program
	{
		private static bool AlphabetSearching(string data)
		{
			int count = 0;
			string alphabet = "abcdefghijklmnopqrstuvwxyz";
			foreach (char a in alphabet)
			{
				foreach (char d in data)
				{
					if (d == a)
					{
						count++;
						break;
					}
				}
			}
			if (count == 26)
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
			Console.WriteLine(AlphabetSearching("zacxyjbbkfgtbhdaielqrm45pnsowtuv"));
			Console.WriteLine(AlphabetSearching("abcdefghijklmnopqrstuvwxyyyy"));
			Console.WriteLine(AlphabetSearching("abc123456kmo"));
		}
	}
}
