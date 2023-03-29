using System.Collections;

namespace _4_LinkedList.SinglyLinkedList;
public class SinglyLinkedList<Type> : IEnumerable<Type> {
    public SinglyLinkedListNode<Type>? Head { get; private set; }

    private Boolean isHeadNull => this.Head is null;

    public SinglyLinkedList() { }

    public SinglyLinkedList(IEnumerable<Type> collection) {
        foreach(Type item in collection) {
            this.AddLast(item);
        }
    }

    public void AddFirst(Type value) {
        // SinglyLinkedListNode<Type> newNode = new(value, Head);
        // Head = newNode;
        this.Head = new(value, this.Head);
    }

    public void AddLast(Type value) {
        if(this.isHeadNull) {
            this.Head = new(value);
            return;
        }

        SinglyLinkedListNode<Type> currentValue = this.Head;

        while(currentValue.Next is not null) {
            currentValue = currentValue.Next;
        }

        currentValue.SetNextValue(new(value));
    }

    public void AddAfter(SinglyLinkedListNode<Type> node, Type value) {
        ArgumentNullException.ThrowIfNull(node);

        if(this.isHeadNull) {
            this.AddFirst(value);
            return;
        }

        SinglyLinkedListNode<Type> newNode = new(value);
        //SinglyLinkedListNode<Type> currentValue = this.Head;

        this.AddNode(node, newNode);
        //while(currentValue is not null) {
        //    if(currentValue.Equals(node)) {
        //        newNode.SetNextValue(currentValue.Next);
        //        currentValue.SetNextValue(newNode);
        //        return;
        //    }

        //    currentValue = currentValue.Next;
        //}
        //throw new ArgumentException($"The reference node ({node.ToString}) is not in this list.");
    }

    public void AddAfter(SinglyLinkedListNode<Type> referenceNode, SinglyLinkedListNode<Type> newNode) {
        if(this.isHeadNull) {
            this.AddFirst(newNode.Value);
            return;
        }

        this.AddNode(referenceNode, newNode);
    }

    public void AddBefore(SinglyLinkedListNode<Type> node, Type value) {
        throw new NotImplementedException();
    }

    public void AddBefore(SinglyLinkedListNode<Type> referenceNode, SinglyLinkedListNode<Type> newNode) {
        throw new NotImplementedException();
    }

    private void AddNode(SinglyLinkedListNode<Type> referenceNode, SinglyLinkedListNode<Type> newNode) {
        ArgumentNullException.ThrowIfNull(referenceNode);
        ArgumentNullException.ThrowIfNull(newNode);
        SinglyLinkedListNode<Type> currentValue = this.Head;

        while(currentValue is not null) {
            if(currentValue.Equals(referenceNode)) {
                newNode.SetNextValue(currentValue.Next);
                referenceNode.SetNextValue(newNode);
                return;
            }

            currentValue = currentValue.Next;
        }

        throw new ArgumentException($"The reference node ({referenceNode.ToString}) is not in this list.");
    }

    public IEnumerator<Type> GetEnumerator() {
        return new SinglyLinkedListEnumerator<Type>(this.Head);
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return this.GetEnumerator();
    }

    public Type RemoveFirst() {
        ArgumentNullException.ThrowIfNull(this.Head, "This list is empty");
        Type firstValue = this.Head.Value;
        this.Head = this.Head.Next;
        return firstValue;
    }

    public Type RemoveLast() {
        ArgumentNullException.ThrowIfNull(this.Head, "This list is empty");

        SinglyLinkedListNode<Type> current = this.Head;

        SinglyLinkedListNode<Type>? previous = null;

        while(current.Next is not null) {
            previous = current;
            current = current.Next;
        }

        Type lastValue = previous.Next.Value;
        previous.RemoveNextValue();

        return lastValue;
    }

    public void Remove(Type value) {
        ArgumentNullException.ThrowIfNull(value, "This value is empty");
        ArgumentNullException.ThrowIfNull(this.Head, "This list is empty");

        SinglyLinkedListNode<Type> currentValue = this.Head;
        SinglyLinkedListNode<Type>? previousValue = null;

        do {
            if(currentValue.Value.Equals(value)) {
                if(currentValue.Next is null) {
                    if(previousValue is null) {
                        this.Head = null;
                        return;
                    }
                    previousValue.RemoveNextValue();
                    return;
                }

                if(previousValue is null) {
                    this.Head = this.Head.Next;
                    return;
                }
                previousValue.SetNextValue(currentValue.Next);
                return;


            }
            previousValue = currentValue;
            currentValue = currentValue.Next;
        } while(currentValue is not null);
        throw new ArgumentException("The value could not be found in this list");
    }
}