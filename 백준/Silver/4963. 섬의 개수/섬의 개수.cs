using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int w = 0;
            int h = 0;

            do
            {
                string[] input = sr.ReadLine().Split(" ");
                int.TryParse(input[0], out w);
                int.TryParse(input[1], out h);
                if(w == 0 && h == 0) // 종료 조건
                {
                    break;
                }

                Island island = new Island(w, h);
                for (int y = 0; y < h; y++)
                {
                    input = sr.ReadLine().Split(" ");
                    for (int x = 0; x < input.Length; x++)
                    {
                        if (input[x] == "1")
                        {
                            island.Map[y, x] = true;
                        }
                    }
                }
                sb.AppendLine(island.FindIsland().ToString());
            }
            // 둘 다 0 이면 종료
            while (w != 0 && h != 0);

            Console.WriteLine(sb.ToString());
        }
    }

    public class Vector2
    {
        public int y;
        public int x;

        // 상하좌우+대각 이동
        public int[] dy = { -1, -1, -1, 0, 0, 1, 1, 1 };
        public int[] dx = { -1, 0, 1, -1, 1, -1, 0, 1 };
        public Vector2(int y, int x)
        {
            this.y = y;
            this.x = x;
        }
        /// <summary>
        /// 범위 체크
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int CheckRange(int pos, int max) 
        {
            pos = Math.Min(max, pos);
            pos = Math.Max(pos, 0);
            return pos;
        }
    }
    public class Island
    {
        public bool[,] Map;
        bool[,] visited;
        List<List<Vector2>> islandList; // 총 이어진 땅의 경로 저장

        public Island(int w, int h)
        {
            Map = new bool[h, w];
            visited = new bool[h, w];
            islandList = new List<List<Vector2>>();
        }
        /// <summary>
        /// DFS를 활용하여 Map을 탐색하여 섬을 찾기
        /// </summary>
        /// <returns></returns>
        public int FindIsland()
        {

            for (int y = 0; y < Map.GetLength(0); y++)
            {
                for (int x = 0; x < Map.GetLength(1); x++)
                {
                    if (Map[y, x] && !visited[y, x])
                    {
                        Vector2 nowPos = new Vector2(y, x); // 시작
                        DFS(nowPos);
                    }
                }
            }
            return islandList.Count;
        }

        /// <summary>
        /// 이어진 땅인지를 파악하는 DFS
        /// </summary>
        /// <param name="nowPos"></param>
        public void DFS(Vector2 nowPos)
        {
            Stack<Vector2> dfs = new Stack<Vector2>();
            List<Vector2> island = new List<Vector2>();

            dfs.Push(nowPos); // 시작 값 저장

            while (dfs.Count > 0) // 스택이 연결되어있는 동안
            {
                nowPos = dfs.Pop();
                island.Add(nowPos); // 탐색한 리스트
                visited[nowPos.y, nowPos.x] = true; // 방문

                for (int ind = 0; ind < nowPos.dy.Length; ind++)
                {
                    // 범위 확인
                    int nowY = nowPos.y + nowPos.dy[ind];
                    nowY = nowPos.CheckRange(nowY, Map.GetLength(0) - 1);
                    int nowX = nowPos.x + nowPos.dx[ind];
                    nowX = nowPos.CheckRange(nowX, Map.GetLength(1) - 1);

                    // 방문 여부 확인
                    if (!visited[nowY, nowX])
                    {
                        if (Map[nowY, nowX])
                        {
                            visited[nowY, nowX] = true; // 방문
                            dfs.Push(new Vector2(nowY, nowX)); // 스택에 저장
                        }
                    }
                }
            }
            islandList.Add(island); // 탐색한 리스트로 추가
        }
    }


}