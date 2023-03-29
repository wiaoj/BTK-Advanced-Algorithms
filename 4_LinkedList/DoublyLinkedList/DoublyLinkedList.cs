using System.Collections;

namespace _4_LinkedList.DoublyLinkedList;
public class DoublyLinkedList<Type> : IEnumerable {
    public DoublyLinkedListNode<Type>? Head { get; private set; }
    public DoublyLinkedListNode<Type>? Tail { get; private set; }

    public DoublyLinkedList() {
        this.Head = null;
        this.Tail = null;
    }

    public DoublyLinkedList(IEnumerable<Type> collection) {
        this.AddLastRange(collection);
    }

    public void AddFirst(Type value) {
        DoublyLinkedListNode<Type> newNode = new(value);

        this.Head?.SetPrevious(newNode);

        newNode.SetNext(this.Head);
        newNode.DeletePrevious();
        this.Head = newNode;

        this.Tail ??= this.Head;
    }

    public void AddLast(Type value) {
        if(this.Tail is null) {
            this.AddFirst(value);
            return;
        }

        DoublyLinkedListNode<Type> newNode = new(value);
        this.Tail.SetNext(newNode);

        newNode.DeleteNext();
        newNode.SetPrevious(this.Tail);

        this.Tail = newNode;
    }

    public void AddLastRange(IEnumerable<Type> collection) {
        foreach(Type? item in collection)
            this.AddLast(item);

    }

    public void AddAfter(DoublyLinkedListNode<Type>? refNode, DoublyLinkedListNode<Type>? newNode) {
        ArgumentNullException.ThrowIfNull(refNode);
        ArgumentNullException.ThrowIfNull(newNode);

        if(refNode == this.Head && refNode == this.Tail) {
            refNode.SetNext(newNode);
            refNode.DeletePrevious();

            newNode.SetPrevious(refNode);
            newNode.DeleteNext();

            this.Head = refNode;
            this.Tail = newNode;
            return;
        }

        if(refNode != this.Tail) {
            newNode.SetPrevious(refNode);
            newNode.SetNext(refNode.Next);

            refNode.Next?.SetPrevious(newNode);
            refNode.SetNext(newNode);
        } else {
            newNode.SetPrevious(refNode);
            newNode.DeleteNext();

            refNode.SetNext(newNode);
            this.Tail = newNode;
        }
    }

    public void AddBefore(DoublyLinkedListNode<Type>? refNode, DoublyLinkedListNode<Type>? newNode) {
        throw new NotImplementedException();
    }

    private List<DoublyLinkedListNode<Type>> GetAllNodes() {
        ArgumentNullException.ThrowIfNull(this.Head);
        List<DoublyLinkedListNode<Type>> list = new();
        DoublyLinkedListNode<Type> current = this.Head;

        while(current is not null) {
            list.Add(current);
            current = current.Next;
        }
        return list;
    }

    public IEnumerator GetEnumerator() {
        return this.GetAllNodes().GetEnumerator();
    }

    public Type RemoveFirst() {
        ArgumentNullException.ThrowIfNull(this.Head);

        Type temp = this.Head.Value;

        if(this.Head == this.Tail) {
            this.Head = null;
            this.Tail = null;
        } else {
            this.Head = this.Head.Next;
            this.Head!.DeletePrevious();
        }

        return temp;
    }

    public Type RemoveLast() {
        ArgumentNullException.ThrowIfNull(this.Tail);

        Type temp = this.Tail.Value;

        if(this.Tail == this.Head) {
            this.Tail = null;
            this.Head = null;
        } else {
            this.Tail.Previous.DeleteNext();
            this.Tail = this.Tail.Previous;
        }
        return temp;
    }

    public void Remove(Type value) {
        ArgumentNullException.ThrowIfNull(this.Head);
        ArgumentNullException.ThrowIfNull(this.Tail);

        if(this.Head == this.Tail) {
            if(this.Head.Value.Equals(value)) {
                this.RemoveFirst();
            }
            return;
        }

        DoublyLinkedListNode<Type>? current = this.Head;

        while(current is not null) {
            //first item
            if(current.Value.Equals(value)) {
                if(current.Previous is null) {
                    current.Next.DeletePrevious();
                    this.Head = current.Next;
                }
                // last item
                else if(current.Next is null) {
                    current.Previous.DeleteNext();
                    this.Tail = current.Previous;
                } else {
                    current.Previous.SetNext(current.Next);
                    current.Next.SetPrevious(current.Previous);
                }
                break;
            }

            current = current.Next;
        }
    }
}