namespace CollectionDemo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# collections");

            doDictionaryDemo();
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doSetDemo();

        }
        private static void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doDictionaryDemo");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");

            Console.WriteLine("Access value using key(key=101): " + dictionary[101]);

            Console.WriteLine("Iterating Dictionary:");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key = " + element.Key + " & Value = " + element.Value);
            }
        }

        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");

            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Vijay");

            //Iterating list elements
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }

        private static void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDemo");

            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Karan");
            stack.Push("Ashish");
            stack.Push("Garima");
            stack.Push("Amit");
            string pop = stack.Pop();

            //Iterating list elements
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Popes element is " + pop);
        }

        private static void doQueueDemo()
        {
            Console.WriteLine("\nIn doQueueDemo");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Jaishankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements");

            //Iterating list elements
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element:" + dequeue);

            Console.WriteLine("\nIterating the queue elements after dequeue one element:");
            //Iterating Queue elements using Enumerator
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        private static void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");

            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Vijay");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            //Iterating list elements
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }


    }
}