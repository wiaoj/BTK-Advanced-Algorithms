namespace _12_SortingAlgorithms.SelectionSort;
public class SelectionSort {
    public static void Sort<Type>(Type[] array) where Type : IComparable {
        for(Int32 index = default; index < array.Length - 1; index++) {
            Int32 minimumIndex = index;
            Type minValue = array[index];

            for(Int32 sortIndex = index + 1; sortIndex < array.Length; sortIndex++) {
                if(array[sortIndex].CompareTo(minValue) < 0) {
                    minimumIndex = sortIndex;
                    minValue = array[sortIndex];
                }
            }
            Sorting.Swap(array, index, minimumIndex);
        }
    }
}