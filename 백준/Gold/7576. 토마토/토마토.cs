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

            // 최종 결과를 담을 배열 : 임의의 큰 수로 시작
            int[,] result = new int[N, M];
            int inputY = 0;

            // 기본 토마토 위치 입력
            int[,] box = new int[N, M];
            inputY = 0;
            while (inputY < N)
            {
                input = sr.ReadLine().Split(" ");
                for (int index = 0; index < input.Length; index++)
                {
                    int.TryParse(input[index], out int num);
                    box[inputY, index] = num;
                    if (num == -1)
                    {
                        result[inputY, index] = -1;
                    }
                    else
                    {
                        result[inputY, index] = 1000000000;
                    }
                }
                inputY++;
            }

            int[] dx = { 0, 0, -1, 1 };
            int[] dy = { -1, 1, 0, 0 };

            Queue<(int, int)> queue = new Queue<(int, int)>();
            // 방문 여부 확인용
            bool[,] visited = new bool[N, M];
            for (int y = 0; y < N; y++)
            {
                for (int x = 0; x < M; x++)
                {
                    // 탐색 진행
                    if (box[y, x] == 1)
                    {
                        queue.Enqueue((y, x));
                        result[y, x] = 0;
                        visited[y, x] = true;
                    }
                }
            }

            // BFS 진행
            while (queue.Count > 0)
            {
                int nowY = queue.Peek().Item1;
                int nowX = queue.Peek().Item2;
                queue.Dequeue();

                for (int index = 0; index < dx.Length; index++)
                {
                    int nextY = nowY + dy[index];
                    int nextX = nowX + dx[index];
                    // y, x 범위 판단
                    if (nextY < 0 || nextY >= box.GetLength(0)) { continue; }
                    if (nextX < 0 || nextX >= box.GetLength(1)) { continue; }
                    // 토마토가 없는 칸
                    if (box[nextY, nextX] == -1) { continue; }
                    // 방문 여부 판단
                    if (visited[nextY, nextX]) { continue; }

                    queue.Enqueue((nextY, nextX));
                    // 원래 저장된 값과 현재 탐색에서의 최소값 저장
                    result[nextY, nextX] = Math.Min(result[nextY, nextX], result[nowY, nowX] + 1);
                    visited[nextY, nextX] = true;
                }
            }
            // 결과값 중 가장 최대값이 익는데 걸린 최소 날짜
            int answer = result.Cast<int>().Max();
            // 기본 값이라면 모두 익지 못한 상태
            if (answer == 1000000000) { Console.WriteLine(-1); }
            else { Console.WriteLine(answer); }
        }
    }
}
