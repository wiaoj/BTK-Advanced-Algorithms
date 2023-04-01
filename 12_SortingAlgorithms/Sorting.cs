namespace _12_SortingAlgorithms;
public class Sorting {
    public static void Swap<Type>(Type[] array, Int32 first, Int32 second) {
        // or => Type tempValue = array[first];
        (array[first], array[second]) = (array[second], array[first]);
    }
}