//using Arrays;

//Array<Int32> array = new();

//for(Int32 index = default; index < 16; index++) {
//    array.Add(index + 1);
//    Console.WriteLine($"{index + 1} has been added to array.");
//    Console.WriteLine(array.Status);
//}

////for(Int32 index = array.Count; index >= 1; index--) {
////    Console.WriteLine($"{array.Remove()} has been removed from the array");
////    Console.WriteLine(array.Status);
////}

//foreach(Int32 item in array) {
//    Console.WriteLine(item);
//}
//Console.WriteLine(new String('-', 20));
////array.Where(x => x % 2 == 0).ToList().ForEach(Console.WriteLine);
//Console.WriteLine(array.Status);

//Array<Int32> clonedArray = array.Clone() as Array<Int32>;

//foreach(Int32 item in clonedArray) {
//    Console.WriteLine(item);
//}

//using _4_LinkedList.SinglyLinkedList;

//SinglyLinkedList<Int32> linkedList = new();
//linkedList.AddFirst(1);
//linkedList.AddFirst(2);
//linkedList.AddFirst(3);

//linkedList.AddLast(4);

//linkedList.AddAfter(linkedList.Head.Next, 99);
//linkedList.AddAfter(linkedList.Head.Next.Next, 100);

//foreach(var item in linkedList) {
//    Console.WriteLine(item);
//}

//using System.Threading.Channels;

//Random random = new();
//IEnumerable<Int32> initial = Enumerable.Range(1, 10).OrderBy(x => random.Next()).ToList();

//LinkedList<Int32> linkedList = new(initial);

//var query = from item in linkedList
//            where item % 2 == 1
//            select item;

//foreach(Int32 item in query) {
//    Console.WriteLine(item);
//}

//linkedList.Where(x => x > 5)
//    .ToList()
//    .ForEach(x => Console.WriteLine(x));

using _4_LinkedList.DoublyLinkedList;

DoublyLinkedList<Int32> doublyList = new();
doublyList.AddFirst(5);
doublyList.AddFirst(7);

doublyList.AddLast(8);
doublyList.AddLast(9);

doublyList.AddAfter(doublyList.Head.Next, new(13));


foreach(var item in doublyList) {
    Console.WriteLine(item);
}

Console.ReadKey();
