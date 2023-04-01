namespace _5_Stack;
public class Stack<Type> {
	private readonly IStack<Type> stack;
	public Int32 Count => this.stack.Count;

	public Stack() : this(StackType.Array) { }
	public Stack(StackType type) {
		switch(type) {
			case StackType.Array:
				this.stack = new ArrayStack<Type>();
				break;
			case StackType.LinkedList:
				this.stack = new LinkedListStack<Type>();
				break;
		}
	}

	public Type Pop() {
		return this.stack.Pop();
	}

	public Type Peek() {
		return this.stack.Peek();
	}

	public void Push(Type value) {
		this.stack.Push(value);
	}
}