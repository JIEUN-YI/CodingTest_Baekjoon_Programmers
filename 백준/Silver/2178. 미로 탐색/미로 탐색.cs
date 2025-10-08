namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int.TryParse(input[0], out int n);
            int.TryParse(input[1], out int m);

            Graph graph = new Graph(n, m);
            for (int indY = 0; indY < graph.Map.GetLength(0); indY++)
            {
                char[] input2 = sr.ReadLine().ToCharArray();
                for (int indX = 0; indX < graph.Map.GetLength(1); indX++)
                {
                    switch (input2[indX])
                    {
                        case '1':
                            graph.Map[indY, indX] = true;
                            break;
                        case '2':
                            graph.Map[indY, indX] = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            graph.FindRoute();
            Console.WriteLine(graph.Visited[n - 1, m - 1]);
        }

    }

    public class Vector2
    {
        public int y;
        public int x;
        public int[] dy = { 0, 0, 1, -1 };
        public int[] dx = { 1, -1, 0, 0 };

        public Vector2(int y, int x)
        {
            this.y = y;
            this.x = x;
        }
    }

    public class Graph
    {
        public bool[,] Map;
        public int[,] Visited; // 각 위치에 도달하기 위한 길의 개수를 저장
        private Queue<Vector2> FindBfs;
        private Vector2 startVec2;
        private Vector2 goalVec2;

        public Graph(int n, int m)
        {
            Map = new bool[n, m];
            Visited = new int[n, m];
            Visited[0, 0] = 1; // 시작지점 이미 방문
            FindBfs = new Queue<Vector2>(100);
            startVec2 = new Vector2(0, 0); // 원점에서 시작
            goalVec2 = new Vector2(n - 1, m - 1); // 목표 지점 설정
            FindBfs.Enqueue(startVec2); // 시작 지점 큐에 저장
        }

        public void FindRoute()
        {
            Vector2 nowVec2 = FindBfs.Dequeue();
            while (nowVec2.y != goalVec2.y || nowVec2.x != goalVec2.x)
            {
                for (int index = 0; index < nowVec2.dx.Length; index++)
                {
                    // 범위를 판정
                    int y = nowVec2.y + nowVec2.dy[index];
                    y = Math.Min(y, Map.GetLength(0) - 1);
                    y = Math.Max(y, 0);
                    int x = nowVec2.x + nowVec2.dx[index];
                    x = Math.Min(x, Map.GetLength(1) - 1);
                    x = Math.Max(x, 0);

                    if (Map[y, x]) // 길이 있고
                    {
                        if (Visited[y, x] == 0) // 방문전인 경우
                        {
                            Vector2 nextVec2 = new Vector2(y, x);
                            Visited[y, x] = Visited[nowVec2.y, nowVec2.x] + 1; // 방문 길이 저장
                            FindBfs.Enqueue(nextVec2);  // 큐에 삽입
                        }
                    }
                }
                nowVec2 = FindBfs.Dequeue();
            }
        }
    }
}