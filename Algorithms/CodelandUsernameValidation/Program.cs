namespace CodelandUsernameValidation
{
	// Write a function that takes a string (str) as a parameter and checks if it is a valid username 
	// according to the following rules:
	// 1) The username must be between 4 and 25 characters long.
	// 2) It must start with a letter.
	// 3) It can only contain letters, numbers, and underscores.
	// 4) It cannot end with an underscore.

	// If the username is valid, the function should return "true"; otherwise, it should return "false".

	// Example Input: Console.WriteLine(CodelandUsernameValidation("aa_"));
	//        Output: false

	// Example Input: Console.WriteLine(CodelandUsernameValidation("u__hello_world123"));
	//        Output: true

	// Example Input: Console.WriteLine(CodelandUsernameValidation("12a_s5aaa"));
	//        Output: false

	// Example Input: Console.WriteLine(CodelandUsernameValidation("u__hello_world123_"));
	//        Output: false

	internal class Program
	{
		private static bool CodelandUsernameValidation(string data)
		{
			if (data.Length < 4 || data.Length > 25)
			{
				return false;
			}
			if (!char.IsLetter(data[0]))
			{
				return false;
			}
			if (data[data.Length - 1] == '_')
			{
				return false;
			}
			if (!data.Contains("_"))
			{
				return false;
			}
			if (!((data[0] >= 65 && data[0] <= 90) || (data[0] >= 97 && data[0] <= 122)))
			{
				return false;
			}
			char[] rakamlar = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
			foreach (var item in data)
			{
				if (rakamlar.Contains(item))
				{
					return true;
				}
			}
			return false;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(CodelandUsernameValidation("aa_"));
			Console.WriteLine(CodelandUsernameValidation("u__hello_world123"));
			Console.WriteLine(CodelandUsernameValidation("12a_s5aaa"));
			Console.WriteLine(CodelandUsernameValidation("u__hello_world123_"));
		}
	}
}
