using Arrays;

Array<Int32> array = new();

for(Int32 index = default; index < 16; index++) {
    array.Add(index + 1);
    Console.WriteLine($"{index + 1} has been added to array.");
    Console.WriteLine(array.Status);
}

//for(Int32 index = array.Count; index >= 1; index--) {
//    Console.WriteLine($"{array.Remove()} has been removed from the array");
//    Console.WriteLine(array.Status);
//}

foreach(Int32 item in array) {
    Console.WriteLine(item);
}
Console.WriteLine(new String('-', 20));
//array.Where(x => x % 2 == 0).ToList().ForEach(Console.WriteLine);
Console.WriteLine(array.Status);

Array<Int32> clonedArray = array.Clone() as Array<Int32>;

foreach(Int32 item in clonedArray) {
    Console.WriteLine(item);
}
