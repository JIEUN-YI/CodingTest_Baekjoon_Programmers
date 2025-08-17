using System.Reflection;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int resultStep = 10000000;
            int resultNode = 0;
            string[] size = sr.ReadLine().Split(" ");
            Graph graph = new Graph(int.Parse(size[0]));
            int.TryParse(size[1], out int count);
            int findCount = int.Parse(size[0]);
            // 관계 그래프 설정
            while (count > 0)
            {
                string[] input = sr.ReadLine().Split(" ");
                graph.MakeGraph(int.Parse(input[0]) - 1, int.Parse(input[1]) - 1);
                count--;
            }
            int node = 0;

            while (node < findCount)
            {
                int result = graph.BFS(node);
                if (resultStep > result)
                {
                    resultStep = result;
                    resultNode = node + 1;
                }
                node++;
            }
            Console.WriteLine(resultNode);
        }
    }
    public class Graph
    {
        public bool[,] graph;
        bool[] visited; // 방문 노드 확인
        public Graph(int x)
        {
            graph = new bool[x, x];
            visited = new bool[x];
        }

        // 그래프 연결 설정
        public void MakeGraph(int x, int y)
        {
            graph[x, y] = true;
            graph[y, x] = true;
        }

        /// <summary>
        /// BFS 큐로 구현
        /// 각 관계 단계 별 개수를 세어 최종 단계의 합을 구하여 리턴
        /// 1단계가 2개의 노드라면 1*2
        /// 2단계가 2개의 노드라면 2*2
        /// 이 모든 합이 최종 단계의 합
        /// </summary>
        /// <param name="nowNode"></param>
        /// <returns></returns>
        public int BFS(int nowNode)
        {
            for(int i = 0; i < visited.Length; i++)
            {
                visited[i] = false;
            }

            int stepR = 1; // 관계의 단계
            int result = 0; // 리턴할 횟수
            Queue<int> queue = new Queue<int>();
            int step = 0; // 한 단계에서 남은 계산할 횟수
            int count = 0; // 단계별 개수
            queue.Enqueue(nowNode); // 큐에 현재 위치 저장
            while (queue.Count > 0)
            {
                int now = queue.Dequeue();
                visited[now] = true;

                for (int next = 0; next < graph.GetLength(0); next++)
                {
                    if (!graph[now, next])
                    {
                       continue;
                    }
                    if (visited[next])
                    {
                        continue;
                    }
                    queue.Enqueue(next);
                    visited[next] = true;
                    count++;
                }
                step--;
                if (step <= 0)
                {
                    step = count;
                    result += stepR * count;
                    stepR++; // 단계 상승
                    count = 0;
                }
            }

            return result;
        }
    }
}