namespace DashInsert
{
	// Write a function that inserts a dash ('-') between each pair of odd numbers in a given string of digits.

	// Example Input: Console.WriteLine(DashInsert("454793"));
	//        Output: 4547-9-3

	// Example Input: Console.WriteLine(DashInsert("99946"));
	//        Output: 9-9-946

	// Example Input: Console.WriteLine(DashInsert("56730"));
	//        Output: 567-30

	internal class Program
	{
		private static string DashInsert(string data)
		{
			string result = "";
			for (int i = 0; i < data.Length - 1; i++)
			{
				if (Convert.ToInt32(data[i]) % 2 != 0 && Convert.ToInt32(data[i + 1]) % 2 != 0)
				{
					result += data[i] + "-";
				}
				else
				{
					result += data[i];
				}
			}
			result += data[data.Length - 1];
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(DashInsert("454793"));
			Console.WriteLine(DashInsert("99946"));
			Console.WriteLine(DashInsert("56730"));
		}
	}
}
