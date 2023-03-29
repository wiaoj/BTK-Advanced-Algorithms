namespace _4_LinkedList.SinglyLinkedList;
public class SinglyLinkedListNode<Type> {
    public SinglyLinkedListNode<Type>? Next { get; private set; }
    public Type Value { get; private set; }

    public SinglyLinkedListNode(Type value) : this(value, default) { }

    public SinglyLinkedListNode(Type value, SinglyLinkedListNode<Type>? next) {
        this.Next = next;
        this.Value = value;
    }

    public void SetNextValue(SinglyLinkedListNode<Type> next) {
        this.Next = next;
    }

    public void RemoveNextValue() {
        this.Next = null;
    }

    public override String ToString() {
        return $"{this.Value}";
    }
}