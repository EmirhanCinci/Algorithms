namespace SwapCase
{
	// Write a function that swaps the case of each letter in the input string. 
	// If a letter is uppercase, it becomes lowercase, and vice versa.

	// Example Input: Console.WriteLine(SwapCase("Merhaba Dünya"));
	//        Output: mERHABA dÜNYA

	// Example Input: Console.WriteLine(SwapCase("EmirhaN CİNCİ"));
	//        Output: eMİRHAn cinci

	internal class Program
	{
		private static string SwapCase(string data)
		{
			string result = "";
			foreach (char item in data)
			{
				if (char.IsLower(item))
				{
					result += item.ToString().ToUpper();
				}
				else if (char.IsUpper(item))
				{
					result += item.ToString().ToLower();
				}
				else
				{
					result += item;
				}
			}
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(SwapCase("Merhaba Dünya"));
			Console.WriteLine(SwapCase("EmirhaN CİNCİ"));
		}
	}
}
