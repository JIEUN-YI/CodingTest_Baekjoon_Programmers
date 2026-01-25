using System.Text;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int N);
            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();

            // 수열을 만들기 위해 주어지는 수
            int[] find = new int[N];
            for (int i = 0; i < N; i++)
            {
                int.TryParse(sr.ReadLine(), out find[i]);
            }

            // 1부터 N까지 입력할 수
            int count = 1;

            // 주어진 수를 돌면서
            foreach (int num in find)
            {
                // 목표 수 까지 push 반복
                while (count <= num)
                {
                    stack.Push(count);
                    sb.AppendLine("+");
                    count++;
                }
                if (stack.Peek() != num)
                {
                    sb.Clear();
                    sb.AppendLine("NO");
                    break;
                }
                else
                {
                    stack.Pop();
                    sb.AppendLine("-");
                    continue;
                }

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
