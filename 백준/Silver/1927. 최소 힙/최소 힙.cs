using System.Text;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int.TryParse(sr.ReadLine(), out int N);

            PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();
            while(N-->0)
            {
                // 현재 값
                int.TryParse(sr.ReadLine(), out int value);
                if(value == 0)
                {
                    if(minHeap.Count == 0)
                    {
                        // 0 출력
                        sb.AppendLine("0");
                    }
                    else
                    {
                        // 최대 값 출력
                        sb.AppendLine(minHeap.Dequeue().ToString());
                    }
                }
                else // 큐에 저장
                {
                    // 최대힙으로 사용하기 위한 우선순위 : * -1
                    minHeap.Enqueue(value, value);
                }
            }
            Console.WriteLine(sb.ToString());   
        }
    }
}
