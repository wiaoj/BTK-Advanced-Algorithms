using System.Collections;

namespace DataStructures;
public class Arrays {
    private void HowToCreateArray() {
        Char[] charArray = new Char[3] { 'a', 'b', 'c' };
        _ = charArray.Length;
        //Array integerArray = Array.CreateInstance(typeof(Int32), 5);
        //integerArray.SetValue(10, 0);
        //integerArray.GetValue(0);
    }

    private void HowToCreateArrayList() {
        // Type Safe - X | it has (boxing -> object) and (unboxing -> object)
        ArrayList arrayList = new();
        arrayList.Add(10);
        arrayList.Add('a');

        Int32 sum = (Int32)arrayList[0] + 20;
        _ = arrayList.Count;
    }

    private void HowToCreateList() {
        List<Int32> list = new();
        list.Add(10);
        list.AddRange(new Int32[] { 1, 2, 3, 4, 5 });
        list.RemoveAt(0);
        //list.Add('a'); -> not working return to byte value
        _ = list.Count;
    }
}