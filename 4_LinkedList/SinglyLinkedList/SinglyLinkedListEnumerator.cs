using System.Collections;

namespace _4_LinkedList.SinglyLinkedList;

internal class SinglyLinkedListEnumerator<Type> : IEnumerator<Type> {
    private SinglyLinkedListNode<Type>? Head;
    private SinglyLinkedListNode<Type>? current;
    public Type Current => this.current.Value;

    Object IEnumerator.Current => this.Current;

    public SinglyLinkedListEnumerator(SinglyLinkedListNode<Type>? head) {
        this.Head = head;
        this.current = default;
    }

    public void Dispose() {
        this.Head = default;
    }

    public Boolean MoveNext() {
        if(this.current is null) {
            this.current = this.Head;
            return true;
        }

        this.current = this.current.Next;
        return this.current is not null;
    }

    public void Reset() {
        this.current = default;
    }
}