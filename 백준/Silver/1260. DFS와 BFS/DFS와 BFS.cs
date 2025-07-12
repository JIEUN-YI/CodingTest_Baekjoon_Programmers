using System.Net.NetworkInformation;
using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int.TryParse(input[0], out int V); // 정점의 개수
            int.TryParse(input[1], out int M); // 간선의 개수
            int.TryParse(input[2], out int start); // 시작 정점

            Graph graph = new Graph(V, M, start); // 그래프 생성

            // 간선의 개수만큼 true 값 입력
            for (int count = 0; count < M; count++)
            {
                string[] input2 = sr.ReadLine().Split(" ");
                int.TryParse(input2[0], out int y);
                int.TryParse(input2[1], out int x);

                graph.nowGraph[y - 1, x - 1] = true;
                graph.nowGraph[x - 1, y - 1] = true;
            }

            graph.DFS(start - 1); // 깊이 우선 탐색
            StringBuilder sb = new StringBuilder();
            foreach (string s in graph.outputList)
            {
                sb.Append(s + " ");
            }
            sb.Append('\n');

            graph.ClearVisited(); // 방문했던 배열 확인과 리스트를 초기화

            graph.BFS(start - 1); // 너비 우선 탐색
            foreach (string s in graph.outputList)
            {
                sb.Append(s + " ");
            }
            Console.WriteLine(sb.ToString());
        }

    }
    public class Graph
    {
        int V; // 정점의 개수
        int M; // 간선의 개수
        int start; // 시작점

        public bool[,] nowGraph;
        bool[] visited; // 방문 여부 확인 배열
        public List<string> outputList; // 출력할 리스트

        public Graph(int V, int M, int start)
        {
            this.V = V;
            this.M = M;
            this.start = start;

            this.nowGraph = new bool[V, V]; // 정점의 개수만큼의 2차원 배열
            this.visited = new bool[V]; // 방문을 확인할 배열 생성
            this.outputList = new List<string>(V); // 결과를 출력할 배열 생성
        }


        /// <summary>
        /// 깊이 우선 탐색
        /// </summary>
        /// <param name="start"></param>
        public void DFS(int nowNode)
        {
            this.visited[nowNode] = true; // 방문 여부 선택
            this.outputList.Add((nowNode + 1).ToString()); // 현재 노드 저장

            // 현재 정점의 연결 여부를 탐색
            for (int next = 0; next < V; next++)
            {
                if (!this.nowGraph[nowNode, next]) // 연결 되어 있지 않다면
                {
                    continue;
                }
                if(this.visited[next]) // 이미 방문한 곳
                {
                    continue;
                }

                DFS(next);
            }
        }

        /// <summary>
        /// 너비 우선 탐색
        /// </summary>
        /// <param name="nowNode"></param>
        public void BFS(int nowNode)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(nowNode); // 큐에 현재 노드 저장
            this.visited[nowNode] = true; // 방문 여부 선택

            while(queue.Count > 0) // queue 용량이 없으면 탐색을 종료
            {
                int now = queue.Dequeue(); // queue의 맨 앞 노드를 빼냄
                outputList.Add((now + 1).ToString()); // 출력 내용에 노드 추가

                for(int next = 0; next < V; next++)
                {
                    if(!this.nowGraph[now, next]) // 연결되어있지 않으면
                    {
                        continue;
                    }
                    if (this.visited[next]) // 탐색을 완료 했으면
                    {
                        continue;
                    }
                    queue.Enqueue(next); // queue에 삽입
                    this.visited[next] = true; // 방문여부 확인
                }
            }
            
        }

        /// <summary>
        /// 방문했던 배열과 결과 리스트 초기화
        /// </summary>
        public void ClearVisited()
        {
            outputList.Clear();
            for (int i = 0; i < V; i++)
            {
                this.visited[i] = false;
            }
        }
    }

}

