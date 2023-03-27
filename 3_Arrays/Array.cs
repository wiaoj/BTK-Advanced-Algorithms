using System.Collections;

namespace Arrays;
public class Array<Type> : IEnumerable<Type>, ICloneable {
    private Type[] innerList;
    public Int32 Count { get; private set; }
    public Int32 Capacity => this.innerList.Length;

    public Array() : this(Array.Empty<Type>()) {
        //this.innerList = Array.Empty<Type>();
        //this.Count = default;
    }

    public Array(params Type[] initial) : this(initial.Length) {
        //this.innerList = new Type[initial.Length];
        //this.Count = default;

        this.AddRange(initial);
    }

    public Array(IEnumerable<Type> collection) : this(collection.Count()) {
        //this.innerList = new Type[collection.Count()];
        //this.Count = default;

        this.AddRange(collection);
    }

    private Array(Int32 innerListLength) {
        this.innerList = new Type[innerListLength];
        this.Count = default;
    }

    public String Status => $"Count: {this.Count} | Capacity: {this.Capacity}";

    public void Add(Type item) {
        if(this.Capacity == this.Count)
            DoubleArrayCapacity();

        this.innerList[Count++] = item;
    }

    public void AddRange(Type[] items) {
        foreach(Type item in items)
            this.Add(item);
    }

    public void AddRange(IEnumerable<Type> items) {
        foreach(Type item in items)
            this.Add(item);
    }

    //public Type Remove() {
    //    return this.Remove(this.Count - 1);
    //}

    public Type Remove(/*Int32 index*/) {
        if(this.Count is 0) 
            throw new Exception($"This array items count is zero!");
        

        //if(index > this.Count) {
        //    throw new Exception($"This index: {index} bigger than array items count: {this.Count}");
        //}

        Type tempItem = this.innerList[this.Count - 1];
        this.Count--;

        if(this.Capacity / 4 >= this.Count) 
            HalfArrayCapacity();
        

        return tempItem;
    }

    private void HalfArrayCapacity() {
        if(this.Capacity < 2)
            return;

        Type[] tempArray = new Type[this.Capacity / 2];
        this.Copy(tempArray, tempArray.Length);
        this.innerList = tempArray;

    }

    private void DoubleArrayCapacity() {
        Int32 newCapacity = this.Capacity is not 0 ? this.Capacity * 2 : 2;
        Type[] tempArray = new Type[newCapacity];

        //for(int index = 0; index < this.Capacity; index++) { }
        this.Copy(tempArray, this.Capacity);
        this.innerList = tempArray;
    }

    private void Copy(Type[] tempArray, Int32 length) {
        System.Array.Copy(this.innerList, tempArray, length);
    }

    public Object Clone() {
        //return this.MemberwiseClone();

        //Deep Copy -> sıfırdan oluşturulur
        Array<Type> array = new();
        array.AddRange(this);
        return array;
    }

    public IEnumerator<Type> GetEnumerator() {
        return this.innerList.Take(this.Count).Select(x => x).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return this.GetEnumerator();
    }
}