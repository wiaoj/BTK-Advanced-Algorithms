using _4_LinkedList.SinglyLinkedList;

namespace _5_Stack;
internal class LinkedListStack<Type> : IStack<Type> {
	private readonly SinglyLinkedList<Type> list = new();
	public Int32 Count { get; private set; }

	public Type Peek() {
		this.IfCountIsZeroThrow();
		return this.list.Head!.Value;
	}

	public Type Pop() {
		this.IfCountIsZeroThrow();
		Type? tempValue = this.list.RemoveFirst();
		this.Count--;
		return tempValue;
	}

	public void Push(Type value) {
		ArgumentNullException.ThrowIfNull(value);
		this.list.AddFirst(value);
		this.Count++;
	}

	private void IfCountIsZeroThrow() {
		if(this.Count is default(Int32))
			throw new Exception("Empty stack");
	}
}