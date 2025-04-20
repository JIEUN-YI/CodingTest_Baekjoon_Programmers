namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(10000);
            int.TryParse(Console.ReadLine(), out int count);
            int num = 0; ;
            while (count > 0)
            {
                string[] answer = Console.ReadLine().Split(" ");
                if (answer.Length == 2)
                {
                    int.TryParse(answer[1], out num);
                }
                switch (answer[0])
                {
                    case "push":
                        Push(queue, num);
                        count--;
                        break;
                    case "pop":
                        Pop(queue);
                        count--;
                        break;
                    case "size":
                        Size(queue);
                        count--;
                        break;
                    case "empty":
                        Empty(queue);
                        count--;
                        break;
                    case "front":
                        Front(queue);
                        count--;
                        break;
                    case "back":
                        Back(queue);
                        count--;
                        break;
                    default:
                        break;
                }
            }
        }
        public static void Push(Queue<int> queue, int num)
        {
            queue.Enqueue(num);
        }
        public static void Pop(Queue<int> queue)
        {
            if (queue.Count == 0)
            {
                Console.WriteLine(-1);
            }
            else
                Console.WriteLine(queue.Dequeue());
        }
        public static void Size(Queue<int> queue)
        {
            Console.WriteLine(queue.Count.ToString());
        }
        public static void Empty(Queue<int> queue)
        {
            if (queue.Count == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
        public static void Front(Queue<int> queue)
        {
            if (queue.Count == 0)
            {
                Console.WriteLine(-1);
            }
            else
                Console.WriteLine(queue.Peek());
        }
        public static void Back(Queue<int> queue)
        {
            if (queue.Count == 0)
            {
                Console.WriteLine(-1);
            }
            else
                Console.WriteLine(queue.Last());
        }
    }
}