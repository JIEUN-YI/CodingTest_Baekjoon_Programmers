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

            Dictionary<int, int> UpRoute = new Dictionary<int, int>();
            Dictionary<int, int> DownRoute = new Dictionary<int, int>();
            while (N > 0)
            {
                input = sr.ReadLine().Split(" ");
                int.TryParse(input[0], out int start);
                int.TryParse(input[1], out int end);
                UpRoute.Add(start, end);
                N--;
            }
            while (M > 0)
            {
                input = sr.ReadLine().Split(" ");
                int.TryParse(input[0], out int start);
                int.TryParse(input[1], out int end);
                DownRoute.Add(start, end);
                M--;
            }

            Queue<int> bfs = new Queue<int>();
            int[] result = new int[101];
            Array.Fill(result, 1000000000);

            bool[] visited = new bool[101];
            bfs.Enqueue(1); // 시작
            visited[1] = true;
            result[0] = 0;
            result[1] = 0;
            
            while (bfs.Count > 0)
            {
                int nowPos = bfs.Dequeue();
                for (int i = 1; i < 7; i++)
                {
                    int nextPos = nowPos + i;
                    
                    // 범위 판단
                    if (nextPos < 0 || nextPos > 100) { continue; }
                    // 사다리 자리라면 다음 위치 변경
                    if (UpRoute.ContainsKey(nextPos))
                    {
                        nextPos = UpRoute[nextPos];
                    }
                    // 뱀 자리라면 다음 위치 변경
                    if (DownRoute.ContainsKey(nextPos))
                    {
                        nextPos = DownRoute[nextPos];
                    }
                    // 방문 판단
                    if (visited[nextPos]) { continue; }

                    result[nextPos] = Math.Min(result[nextPos], result[nowPos] + 1);
                    bfs.Enqueue(nextPos);
                    visited[nextPos] = true;
                }
            }

            Console.WriteLine(result[100]);
        }
    }
}