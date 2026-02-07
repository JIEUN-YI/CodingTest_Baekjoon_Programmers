namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int.TryParse(input[0], out int startPos);
            int.TryParse(input[1], out int endPos);

            // 얼마나 걸렸는지 최소값을 비교, 저장할 배열
            int[] timePos = new int[100001];
            timePos = Enumerable.Repeat(-1,timePos.Length).ToArray(); // 모든 배열 값을 -1로 시작
            // bfs 탐색용 큐
            Queue<int> bfs = new Queue<int>();

            // 위치 이동 배열
            int[] findPos = { -1, 1, 2 };
            bfs.Enqueue(startPos); // 시작 위치 저장
            timePos[startPos] = 0; // 시작
            while (bfs.Count > 0)
            {
                // 현재 위치
                int nowPos = bfs.Dequeue();
                
                for(int i = 0; i < findPos.Length; i++)
                {
                    int nextPos = 0;
                    // 다음 위치 찾기
                    if (i == 2) { nextPos = nowPos * findPos[i]; }
                    else
                    {
                        nextPos = nowPos + findPos[i];
                    }

                    // 다음 위치의 범위 판단
                    if (nextPos < 0 || nextPos > 100000) { continue; }
                    // 다음 위치 방문 여부 판단
                    if (timePos[nextPos] != -1) { continue; }

                    timePos[nextPos] = timePos[nowPos] + 1;
                    // 큐에 저장
                    bfs.Enqueue(nextPos);
                }
            }
            Console.WriteLine(timePos[endPos]);
        }
    }
}
