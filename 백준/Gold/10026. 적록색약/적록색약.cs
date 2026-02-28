namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int N);
            int[,] map = new int[N, N];

            // 지도 표시
            for (int y = 0; y < N; y++)
            {
                string input = sr.ReadLine();
                for (int x = 0; x < N; x++)
                {
                    switch (input[x])
                    {
                        case 'R':
                            map[y, x] = 0;
                            break;
                        case 'G':
                            map[y, x] = 1;
                            break;
                        case 'B':
                            map[y, x] = 2;
                            break;
                        default:
                            break;
                    }
                }
            }

            int all =AllColors(map);
            int notAll = SameColors(map);

            Console.WriteLine(all + " " + notAll);
        }

        public static int AllColors(int[,] map)
        {
            // 방문 탐색
            bool[,] visited = new bool[map.GetLength(0), map.GetLength(1)];
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };
            int section = 0;

            Stack<(int, int)> dfs = new Stack<(int, int)>();

            // 모든 색상을 보는 경우
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (!visited[y, x])
                    {
                        dfs.Push((y, x));

                        // DFS 탐색 시작
                        while (dfs.Count > 0)
                        {
                            int nowY = dfs.Peek().Item1;
                            int nowX = dfs.Peek().Item2;
                            dfs.Pop();
                            visited[nowY, nowX] = true; // 방문 확인

                            // 상하이동
                            for (int i = 0; i < dx.Length; i++)
                            {
                                int nextX = dx[i] + nowX;
                                int nextY = dy[i] + nowY;

                                // 범위 확인
                                if (nextY < 0 || nextY >= map.GetLength(0)) { continue; }
                                if (nextX < 0 || nextX >= map.GetLength(1)) { continue; }
                                // 방문 여부 확인
                                if (visited[nextY, nextX]) { continue; }
                                // 같은 색상 확인
                                if (map[nowY, nowX] != map[nextY, nextX]) { continue; }
                                dfs.Push((nextY, nextX));
                            }
                        }
                        section++;
                    }
                }

            }
            return section;
        }

        public static int SameColors(int[,] map)
        {
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };
            int section = 0;

            // 방문 탐색
            bool[,] visited = new bool[map.GetLength(0), map.GetLength(1)];
            Stack<(int, int)> dfs = new Stack<(int, int)>();

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (!visited[y, x])
                    {
                        dfs.Push((y, x));

                        // DFS 탐색 시작
                        while (dfs.Count > 0)
                        {
                            int nowY = dfs.Peek().Item1;
                            int nowX = dfs.Peek().Item2;
                            dfs.Pop();
                            visited[nowY, nowX] = true; // 방문 확인

                            // 상하이동
                            for (int i = 0; i < dx.Length; i++)
                            {
                                int nextX = dx[i] + nowX;
                                int nextY = dy[i] + nowY;

                                // 범위 확인
                                if (nextY < 0 || nextY >= map.GetLength(0)) { continue; }
                                if (nextX < 0 || nextX >= map.GetLength(1)) { continue; }
                                // 방문 여부 확인
                                if (visited[nextY, nextX]) { continue; }
                                // 빨강 또는 초록
                                if (map[nowY, nowX] == 0 || map[nowY,nowX]==1)
                                {
                                    // 다음 색이 파랑이면 제외
                                    if(map[nextY, nextX] == 2) { continue; }
                                    else
                                    {
                                        dfs.Push((nextY, nextX));
                                        continue;
                                    }
                                }
                                if (map[nowY, nowX] != map[nextY, nextX]) { continue; }
                                dfs.Push((nextY, nextX));
                            }
                        }
                        section++;
                    }
                }

            }
            return section;
        }
    }
}