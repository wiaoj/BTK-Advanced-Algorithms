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

//using _4_LinkedList.DoublyLinkedList;

//DoublyLinkedList<Int32> doublyList = new();
//doublyList.AddFirst(5);
//doublyList.AddFirst(7);

//doublyList.AddLast(8);
//doublyList.AddLast(9);

//doublyList.AddAfter(doublyList.Head.Next, new(13));

//foreach(var item in doublyList) {
//    Console.WriteLine(item);
//}

//Console.ReadKey();

using _5_Stack;

Char[] charSet = { 'a', 'b', 'c','d','e' };
_5_Stack.Stack<Char> stack = new();
_5_Stack.Stack<Char> stack2 = new(StackType.LinkedList);

foreach(var item in charSet) {
	stack.Push(item);
	stack2.Push(item);
}

Console.WriteLine($"Count: {stack.Count}");
Console.WriteLine($"Count: {stack2.Count}");

Console.WriteLine($"Peek: {stack.Peek()}");
Console.WriteLine($"Peek: {stack2.Peek()}");

Console.WriteLine($"Pop: {stack.Pop()}");
Console.WriteLine($"Pop: {stack2.Pop()}");

Console.WriteLine($"Peek: {stack.Peek()}");
Console.WriteLine($"Peek: {stack2.Peek()}");

Console.WriteLine(PostFixExample.Run("231*+9-")); //-4
//using _12_SortingAlgorithms.SelectionSort;

//Int32[] array = { 16, -71, 23, 44, -55, 12, 0,-7, 55, 40, 6, 82, -7 };

//foreach(Int32 item in array) {
//    Console.Write($"{item,-5}");
//}

//Console.WriteLine();

//SelectionSort.Sort<Int32>(array);

//foreach(Int32 item in array) {
//    Console.Write($"{item,-5}");
//}

//Console.ReadKey();
