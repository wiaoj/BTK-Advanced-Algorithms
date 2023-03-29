namespace _4_LinkedList.DoublyLinkedList;
public class DoublyLinkedListNode<Type> {
    public DoublyLinkedListNode<Type>? Previous { get; private set; }
    public DoublyLinkedListNode<Type>? Next { get; private set; }
    public Type Value { get; private set; }

    public DoublyLinkedListNode(Type value) {
        this.Value = value;
    }

    public void DeletePrevious() {
        this.Previous = null;
    }

    public void SetPrevious(DoublyLinkedListNode<Type>? value) {
        this.Previous = value;
    }

    public void DeleteNext() {
        this.Next = null;
    }

    public void SetNext(DoublyLinkedListNode<Type>? value) {
        this.Next = value;
    }

    public override String ToString() {
        return $"{this.Value}";
    }
}