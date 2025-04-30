using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int.TryParse(input[0], out int N);
            int.TryParse(input[1], out int K);


            StringBuilder sb = new StringBuilder();
            sb.Append("<");
            Queue<int> queue = new Queue<int>(N);
            for (int i = 1; i <= N; i++)
            {
                queue.Enqueue(i);
            }
            while (queue.Count > 0)
            {
                for (int count = 1; count <= K; count++)
                {
                    if(count != K) // 제거하지 않은 수는 뒤에 삽입
                    {
                        queue.Enqueue(queue.Dequeue());
                        continue;
                    }
                    else
                    {
                        sb.Append(queue.Dequeue() + ", "); // 카운팅한 수는 제거 후 결과 저장
                    }
                }
            }
            sb.Remove(sb.Length - 2, 2); // 맨 마지막 "," 삭제
            sb.Append(">");
            Console.WriteLine(sb.ToString());
        }
    }
}