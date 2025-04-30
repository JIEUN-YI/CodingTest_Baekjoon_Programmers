using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int count);
            Stack<int> stack = new Stack<int>();

            // StringBuilder 사용
            StringBuilder sb = new StringBuilder();

            while (count > 0)
            {
                string[] input = Console.ReadLine().Split(" ");
                switch (input[0])
                {
                    case "push":
                        stack.Push(int.Parse(input[1])); // 정수를 삽입
                        break;
                    case "pop":
                        if (stack.Count != 0) // 용량이 있으면 Pop
                        {
                            sb.Append(stack.Pop() +"\n");
                        }
                        else // 용량이 없으면
                        {
                            sb.AppendLine("-1");
                        }
                        break;
                    case "size":
                        sb.Append(stack.Count + "\n"); // 스택 용량 출력
                        break;
                    case "empty":
                        if (stack.Count != 0)
                        {
                            sb.AppendLine("0");
                        }
                        else // 스택이 비어있으면
                        {
                            sb.AppendLine("1");
                        }
                        break;
                    case "top":
                        if (stack.Count == 0) // 용량이 없으면
                        {
                            sb.AppendLine("-1");
                        }
                        else
                        {
                            sb.Append(stack.Peek() +"\n");
                        }
                        break;
                }
                count--;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}