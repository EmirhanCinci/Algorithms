namespace ABCheck
{
	// Write a function that checks if there is exactly 3 characters between 'a' and 'b' in the given string.
	// The function should return true if the condition is met, otherwise false.

	// Example Input: Console.WriteLine(ABCheck("after badly"));
	//        Output: false

	// Example Input: Console.WriteLine(ABCheck("Laura sobs"));
	//        Output: true

	internal class Program
	{
		private static bool ABCheck(string data)
		{
			for (int i = 0; i < data.Length; i++)
			{
				if ((data[i] == 'a' && (i + 4) < data.Length && data[i + 4] == 'b') || (data[i] == 'b' && (i + 4) < data.Length && data[i + 4] == 'a'))
				{
					return true;
				}
			}
			return false;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(ABCheck("after badly"));
			Console.WriteLine(ABCheck("Laura sobs"));
		}
	}
}
