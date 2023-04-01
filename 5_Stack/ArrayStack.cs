namespace _5_Stack;
internal class ArrayStack<Type> : IStack<Type> {
	private readonly List<Type> list = new();

	public Int32 Count { get; private set; }

	public Type Peek() {
		this.IfCountIsZeroThrow();
		return this.list[^1];
	}

	public Type Pop() {
		this.IfCountIsZeroThrow();
		Type? value = this.list[^1];
		this.list.Remove(value);
		return value;
	}

	public void Push(Type value) {
		ArgumentNullException.ThrowIfNull(value);
		this.list.Add(value);
		this.Count++;
	}

	private void IfCountIsZeroThrow() {
		if(this.Count is default(Int32)) 
			throw new Exception("Empty stack");
	}
}