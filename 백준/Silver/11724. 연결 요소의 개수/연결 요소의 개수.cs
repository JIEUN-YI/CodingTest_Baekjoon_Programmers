using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int.TryParse(input[0], out int N);
            int.TryParse(input[1], out int M);
            Graph graph = new Graph(N, M);
            while (M > 0)
            {
                string[] inputNode = sr.ReadLine().Split(" ");
                graph.nowGraph[int.Parse(inputNode[0]) - 1, int.Parse(inputNode[1]) - 1] = true; // 입력 값 - 1 로 저장해서 인덱스와 맞추기
                graph.nowGraph[int.Parse(inputNode[1]) - 1, int.Parse(inputNode[0]) - 1] = true; // 입력 값 - 1 로 저장해서 인덱스와 맞추기
                M--;
            }
            graph.CheckCount();
            Console.WriteLine(graph.count);
        }
    }

    public class Graph
    {
        int V; // 정점의 개수
        int M; // 간선의 개수
        public int count;

        public bool[,] nowGraph;
        bool[] visited; // 방문 여부 확인 배열


        public Graph(int V, int M)
        {
            this.V = V;
            this.M = M;
            count = 0;
            this.nowGraph = new bool[V, V]; // 정점의 개수만큼의 2차원 배열
            this.visited = new bool[V]; // 방문을 확인할 배열 생성

        }

        /// <summary>
        /// DFS 탐색이 한번 끝나면 연결된 요소의 탐방이 종료됨
        /// 방문하지 않은 배열만 확인하여 다시 DFS()
        /// </summary>
        public void CheckCount()
        {
            for(int index = 0;  index < visited.Length; index++)
            {
                if (!visited[index])
                {
                    DFS(index);
                    count++;
                }
                else
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// 깊이 우선 탐색
        /// </summary>
        /// <param name="start"></param>
        public void DFS(int nowNode)
        {
            this.visited[nowNode] = true; // 방문 여부 선택

            // 현재 정점의 연결 여부를 탐색
            for (int next = 0; next < V; next++)
            {
                if (!this.nowGraph[nowNode, next]) // 연결 되어 있지 않다면
                {
                    continue;
                }
                if (this.visited[next]) // 이미 방문한 곳
                {
                    continue;
                }
                DFS(next);
            }
        }
    }
}