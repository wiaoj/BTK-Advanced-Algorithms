namespace _5_Stack;
public interface IStack<Type> {
	public Int32 Count { get; }
	public void Push(Type value);
	public Type Peek();
	public Type Pop();
}