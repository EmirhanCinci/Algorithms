namespace ExOh
{
	// Write a function that takes a string as input and checks if the number of 'x' characters is equal to the number of 'o' characters in the string.
	// The string will only contain the characters 'x' and 'o', and no punctuation or numbers will be present.
	// Return true if the counts are equal, otherwise return false.

	// Example Input: Console.WriteLine(ExOh("xooxxxxooxo"));
	//		  Output: false

	// Example Input: Console.WriteLine(ExOh("xooxxo"));
	//		  Output: true

	// Example Input: Console.WriteLine(ExOh("x"));
	//		  Output: false

	internal class Program
	{
		public static bool ExOh(string data)
		{
			data = data.ToLower();
			int xCount = 0;
			int oCount = 0;
			for (int i = 0; i < data.Length; i++)
			{
				if (data[i] == 120)
				{
					xCount++;
				}
				if (data[i] == 111)
				{
					oCount++;
				}
			}
			if (oCount == xCount)
			{
				return true;
			}
			return false;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(ExOh("xooxxxxooxo"));
			Console.WriteLine(ExOh("xooxxo"));
			Console.WriteLine(ExOh("x"));
		}
	}
}
