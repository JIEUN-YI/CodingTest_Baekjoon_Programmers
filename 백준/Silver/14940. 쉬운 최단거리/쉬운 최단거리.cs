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
            int[,] map = new int[N, M];

            // 목표지점 = 탐색 시작 지점 = 지도에서 값이 2인 위치
            int startY = 0;
            int startX = 0;
            // 지도 그리기
            for (int y = 0; y < map.GetLength(0); y++)
            {
                input = sr.ReadLine().Split(" ");
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    int.TryParse(input[x], out int num);
                    if (num == 2)
                    {
                        // 시작 지점 지정
                        startY = y;
                        startX = x;
                    }

                    map[y, x] = num;
                }
            }

            // 방문 방향
            int[] dirY = { 1, -1, 0, 0 };
            int[] dirX = { 0, 0, 1, -1 };
            // 방문한 위치
            int[,] result = new int[N, M];
            bool[,] visited = new bool[N, M];
            for (int y = 0; y < result.GetLength(0); y++)
            {
                for (int x = 0; x < result.GetLength(1); x++)
                {
                    if (map[y, x] == 0) { continue; }
                    result[y, x] = 100001;
                }
            }
            // 탐색용 큐
            Queue<(int, int)> bfs = new Queue<(int, int)>();

            bfs.Enqueue((startY, startX));

            // 시작 지점 방문
            visited[startY, startX] = true;
            result[startY, startX] = 0;

            while (bfs.Count > 0)
            {
                int nowY = bfs.Peek().Item1;
                int nowX = bfs.Peek().Item2;
                bfs.Dequeue();
                for (int index = 0; dirX.Length > index; index++)
                {
                    int nextY = nowY + dirY[index];
                    int nextX = nowX + dirX[index];

                    // 범위 판단
                    if (nextY < 0 || nextY >= map.GetLength(0)) { continue; }
                    if (nextX < 0 || nextX >= map.GetLength(1)) { continue; }
                    // 길 여부 판단
                    if (map[nextY, nextX] == 0) { continue; }

                    // 최솟값 확인
                    result[nextY, nextX] = Math.Min(result[nowY, nowX] + 1, result[nextY, nextX]);

                    // 방문 여부 판단
                    if (visited[nextY, nextX]) { continue; }
                    // 큐에 저장
                    bfs.Enqueue((nextY, nextX));
                    visited[nextY, nextX] = true;
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int y = 0; y < result.GetLength(0); y++)
            {
                for (int x = 0; x < result.GetLength(1); x++)
                {
                    if (result[y, x] == 100001) { sb.Append(-1); }
                    else { sb.Append(result[y, x]); }
                    sb.Append(" ");
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
