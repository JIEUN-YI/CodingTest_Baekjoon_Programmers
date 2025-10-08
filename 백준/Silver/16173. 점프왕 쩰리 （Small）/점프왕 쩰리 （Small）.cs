namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int.TryParse(sr.ReadLine(), out int n);
            Graph graph = new Graph(n);
            for (int y = 0; y < n; y++)
            {
                string[] input = sr.ReadLine().Split(" ");
                for (int x = 0; x < n; x++)
                {
                    int.TryParse(input[x], out int num);
                    graph.Map[y, x] = num;
                }
            }

            graph.DFS();

            if (graph.goal)
            {
                Console.WriteLine("HaruHaru");
            }
            else
            {
                Console.WriteLine("Hing");
            }
        }
    }

    public class Vector2
    {
        public int y;
        public int x;

        public Vector2(int y, int x)
        {
            this.y = y;
            this.x = x;
        }
    }

    public class Graph
    {
        public int[,] Map;
        public bool[,] Visited;
        private Stack<Vector2> stack;
        public bool goal = false; // 목표 도달 여부

        public Graph(int n)
        {
            Map = new int[n, n];
            Visited = new bool[n, n];
            stack = new Stack<Vector2>();
            stack.Push(new Vector2(0, 0)); // 시작 지점 저장
            Visited[0, 0] = true;
        }
        /// <summary>
        /// 위치 방문 여부 확인
        /// </summary>
        /// <param name="pos"></param>
        public void CheckVisited(Vector2 pos)
        {
            if (!Visited[pos.y, pos.x])
            {
                Visited[pos.y, pos.x] = true;
                stack.Push(pos);
            }
        }
        public void DFS()
        {
            while (stack.Count > 0)
            {
                Vector2 nowPos = stack.Pop(); // 스택에서 출력
                if (Map[nowPos.y, nowPos.x] == -1) // 목표 지점 도달 시
                {
                    goal = true;
                    break;
                }

                int plus = Map[nowPos.y, nowPos.x]; // 이동할 수 있는 값
                // 범위 확인
                if (nowPos.y + plus < Map.GetLength(0))
                {
                    Vector2 nextPosDown = new Vector2(nowPos.y + plus, nowPos.x);
                    CheckVisited(nextPosDown);
                }
                if (nowPos.x + plus < Map.GetLength(1))
                {
                    Vector2 nextPosRight = new Vector2(nowPos.y, nowPos.x + plus);
                    CheckVisited(nextPosRight);
                }
            }
        }
    }
}