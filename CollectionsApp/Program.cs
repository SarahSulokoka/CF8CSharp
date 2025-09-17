namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int> {  };

            intList.Add(1);
            intList.AddRange(new int[] {1, 2, 3});
            intList.Insert(0, 1);
            intList.Remove(1);
            intList.RemoveAt(1);
            intList.Reverse();
            intList.Sort(); // natural sort , 1 2 3 4 5
            intList.Clear();
            intList.Contains(3);

            int intListLength = intList.Count;

            int num = intList[1];
            intList[1] = 10;    


            var list = new LinkedList<string>();
            var item1 = list.AddFirst("CF1");
            var item0 = list.AddBefore(item1, "CF0");
            var item2 = list.AddAfter(item1, "CF2");
            list.AddLast("CF3");

            list.Last!.Previous!.Previous!.Value = "Factory";

            foreach (string str in list)
            {
                Console.WriteLine(str + " ");
            }

            //Dictionary
            var words = new Dictionary<int, string>();
            words.Add(1, "Hello");
            words[2] = "AUEB";
            words[3] = "Coding";
            words.Remove(2);

            foreach (var kvp in words)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }


            var stack = new Stack<string>();
            stack.Push("AB8273");
            stack.Push("AB6473");
            stack.Push("AB1234");   


            var lastCar = stack.Pop();

            foreach (var car in stack)
            {
                Console.WriteLine(car);
            }

            var queue = new Queue<string>();
            queue.Enqueue("AB8273");
            queue.Enqueue("AB6473");
            queue.Enqueue("AB1234");

            var firstCar = queue.Dequeue();

            foreach (var car in queue)
            {
                Console.WriteLine(car);
            }
        }
    }
}
