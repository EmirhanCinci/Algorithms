namespace ValidParantheses
{
	// Write an algorithm to check if the parentheses in a given string are properly opened and closed in the correct order.

	// Example input: Console.WriteLine(ValidParantheses("()"));
	//		  Output: true

	// Example input: Console.WriteLine(ValidParantheses("()[]{}"));
	//		  Output: true

	// Example input: Console.WriteLine(ValidParantheses("(]"));
	//		  Output: false
			
	// Example input: Console.WriteLine(ValidParantheses("((5 + 2) * 3) - [8 / {4 - 2}]"));
	//		  Output: true

	// Example input: Console.WriteLine(ValidParantheses("((5 + 2) * 3] - [8 / {4 - 2}]"));
	//		  Output: false

	internal class Program
	{
		private static bool ValidParantheses(string data)
		{
			Stack<char> stack = new Stack<char>();
			foreach (char c in data)
			{
				if (c == '(' || c == '{' || c == '[')
				{
					stack.Push(c);
				}
				else if (c == ')' || c == '}' || c == ']')
				{
					if (stack.Count == 0)
					{
						return false;
					}
					char last = stack.Pop();
					if ((last == '(' && c != ')') || (last == '{' && c != '}') || (last == '[' && c != ']'))
					{
						return false;
					}
				}
			}
			return stack.Count == 0;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(ValidParantheses("()"));
			Console.WriteLine(ValidParantheses("()[]{}"));
			Console.WriteLine(ValidParantheses("(]"));
			Console.WriteLine(ValidParantheses("((5 + 2) * 3) - [8 / {4 - 2}]"));
			Console.WriteLine(ValidParantheses("((5 + 2) * 3] - [8 / {4 - 2}]"));
		}
	}
}
