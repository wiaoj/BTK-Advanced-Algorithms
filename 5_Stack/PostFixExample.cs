using System;

namespace _5_Stack;
public class PostFixExample {
	private String expression;
	private readonly LinkedListStack<String> Stack = new();

	private String Expression() {
		Int32 result = default;

		for(Int32 index = default; index < this.expression.Length; index++) {
			String character = this.expression.Substring(index, 1);

			if(Char.IsNumber(character[0])) {
				this.Stack.Push(character);
				continue;
			}

			Int32 value1 = Int32.Parse(this.Stack.Pop());
			Int32 value2 = Int32.Parse(this.Stack.Pop());

			if(character.Equals("*"))
				result = value2 * value1;
			else if(character.Equals("/"))
				result = value2 / value1;
			else if(character.Equals("+"))
				result = value2 + value1;
			else if(character.Equals("-"))
				result = value2 - value1;

			this.Stack.Push(result.ToString());
		}

		return this.Stack.Pop();
	}

	public static String Run(String expression) {
		PostFixExample postFix = new() {
			expression = expression
		};
		return postFix.Expression();
	}
}