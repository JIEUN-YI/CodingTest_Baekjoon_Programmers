using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int testCase);
            StringBuilder sb = new StringBuilder();
            while (testCase > 0)
            {
                string[] input = sr.ReadLine().Split(" ");
                int.TryParse(input[0], out int N); // 문서의 개수
                int.TryParse(input[1], out int M); // 찾으려는 문서의 Index

                // 위치와 우선순위를 가진 IndexProiority를 가진 Queue
                Queue<IndexPriority> queue = new Queue<IndexPriority>();

                input = sr.ReadLine().Split(" ");

                // 입력 값으로 Queue 생성
                for (int index = 0; index < input.Length; index++)
                {
                    IndexPriority node = new IndexPriority();
                    node.index = index;
                    int.TryParse(input[index], out node.priority);
                    queue.Enqueue(node);
                }

                // 우선순위가 가장 높은 것
                int maxNum = queue.Max(x => x.priority);

                // 몇번째로 인쇄되는지
                int count = 1;
                while (queue.Count > 0)
                {
                    IndexPriority nowNode = queue.Dequeue();
                    // 출력 할 차례
                    if (nowNode.priority >= maxNum)
                    {
                        // 찾으려는 문서인지 확인
                        if (nowNode.index == M)
                        {
                            sb.AppendLine(count.ToString());
                            break;
                        }
                        else
                        {
                            count++;
                            // 출력 후 남은 것 중 최고값 찾기
                            maxNum = queue.Max(x => x.priority);
                        }
                    }
                    // 뒤로 보낼 차례
                    else
                    {
                        queue.Enqueue(nowNode);
                    }
                }
                testCase--;
            }
            Console.WriteLine(sb);
        }
    }

    // 위치와 우선순위를 가진 IndexProiority
    public struct IndexPriority
    {
        public int index;
        public int priority;
    }

}
