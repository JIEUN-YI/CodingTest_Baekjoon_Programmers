namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int.TryParse(input[0], out int M);
            int.TryParse(input[1], out int N);
            int.TryParse(input[2], out int H);

            // 최종 결과를 담을 배열 : 임의의 큰 수로 시작
            // 3차원 배열 [ 깊이, 세로, 가로 ] 
            int[,,] result = new int[H, N, M];

            // 기본 토마토 위치 입력
            int[,,] box = new int[H, N, M];

            int inputZ = 0;
            while (inputZ < H)
            {
                int inputY = 0;
                while (inputY < N)
                {
                    input = sr.ReadLine().Split(" ");
                    for (int i = 0; i < input.Length; i++)
                    {
                        int.TryParse(input[i], out int value);
                        box[inputZ, inputY, i] = value;
                        if (value == -1)
                        {
                            result[inputZ, inputY, i] = -1;
                        }
                        else
                        {
                            result[inputZ, inputY, i] = 1000000000;
                        }
                    }
                    inputY++;
                }
                inputZ++;
            }


            int[] dx = { 0, 0, -1, 1 };
            int[] dy = { -1, 1, 0, 0 };
            int[] dz = { -1, 1 };

            // 3차원 배열 [ 깊이, 세로, 가로 ] = Z, Y, X
            Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
            bool[,,] visited = new bool[H, N, M];

            // 시작 지점 저장
            for (int z = 0; z < H; z++)
            {
                for (int y = 0; y < N; y++)
                {
                    for (int x = 0; x < M; x++)
                    {
                        if (box[z, y, x] == 1)
                        {
                            queue.Enqueue((z, y, x));
                            result[z, y, x] = 0;
                            visited[z, y, x] = true;
                        }
                    }
                }
            }

            // BFS 탐색
            while (queue.Count > 0)
            {
                int nowZ = queue.Peek().Item1;
                int nowY = queue.Peek().Item2;
                int nowX = queue.Peek().Item3;
                queue.Dequeue();
                for (int index = 0; index < dz.Length; index++)
                {
                    // 위 아래 높이로 탐색
                    int nextZ = nowZ + dz[index];
                    if (nextZ < 0 || nextZ >= H) { continue; }
                    if (box[nextZ, nowY, nowX] == -1) { continue; }
                    if (visited[nextZ, nowY, nowX]) { continue; }
                    // 예외처리 후 최솟값 저장
                    queue.Enqueue((nextZ, nowY, nowX));
                    result[nextZ, nowY, nowX] = Math.Min(result[nextZ, nowY, nowX], result[nowZ, nowY, nowX] + 1);
                    visited[nextZ, nowY, nowX] = true;
                }
                for (int index = 0; index < dx.Length; index++)
                {
                    // 가로 세로 방향 탐색
                    int nextY = nowY + dy[index];
                    int nextX = nowX + dx[index];
                    if (nextY < 0 || nextY >= N) { continue; }
                    if (nextX < 0 || nextX >= M) { continue; }
                    if (box[nowZ, nextY, nextX] == -1) { continue; }
                    if (visited[nowZ, nextY, nextX]) { continue; }
                    // 예외처리 후 최솟값 저장
                    queue.Enqueue((nowZ, nextY, nextX));
                    result[nowZ, nextY, nextX] = Math.Min(result[nowZ, nextY, nextX], result[nowZ, nowY, nowX] + 1);
                    visited[nowZ, nextY, nextX] = true;
                }
            }
            int answer = result.Cast<int>().Max();
            if (answer == 1000000000) { Console.WriteLine(-1); }
            else { Console.WriteLine(answer); }
        }
    }
}