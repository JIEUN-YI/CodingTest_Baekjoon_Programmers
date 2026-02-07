using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int N);
            int[,] map = new int[N, N];

            // 맵 그리기
            for (int y = 0; y < N; y++)
            {
                string input = sr.ReadLine();
                int x = 0;
                foreach (char c in input)
                {
                    if (c == '0') { map[y, x] = 0; }
                    else { map[y, x] = -1; } // 단지의 기본값 -1 = 아직 탐색하지 않은 단지
                    x++;
                }
            }

            int numbering = 1; // 단지 넘버링
            // 상하좌우 이동
            int[] dirX = { 0, 0, -1, 1 };
            int[] dirY = { -1, 1, 0, 0 };

            // DFS용 스택 : (y, x)로 저장
            Stack<(int, int)> dfs = new Stack<(int, int)>();
            // 총 단지별 집의 수
            List<int> countHouse = new List<int>();

            // 지도 탐방 : 넘버링 시작
            for (int y = 0; y < N; y++)
            {
                for (int x = 0; x < N; x++)
                {
                    // 위치가 방문 전이고, 탐색해야할 때
                    if (map[y, x] == -1)
                    {
                        int houses = 0;
                        // 스택 추가
                        dfs.Push((y, x));
                        // 단지 넘버링 저장
                        map[y, x] = numbering;
                        // 탐색 시작
                        while (dfs.Count > 0)
                        {
                            int nowY = dfs.Peek().Item1;
                            int nowX = dfs.Peek().Item2;
                            dfs.Pop();
                            // 단지의 집 개수 세기
                            houses++;

                            // 방향 탐색
                            for (int index = 0; index < dirY.Length; index++)
                            {
                                int nextY = nowY + dirY[index];
                                int nextX = nowX + dirX[index];

                                // 범위 확인
                                if (nextY < 0 || nextY >= N) { continue; }
                                if (nextX < 0 || nextX >= N) { continue; }
                                // 집인지 확인
                                if (map[nextY, nextX] == 0) { continue; }
                                // 방문 여부 확인
                                if (map[nextY, nextX] != -1) { continue; }

                                // 집이고 단지 넘버링 전이면
                                map[nextY, nextX] = numbering;
                                dfs.Push((nextY, nextX));
                            }
                        }
                        // 해당 연결된 단지 전부 탐색 = 다음 단지 넘버링으로 변경
                        numbering++;
                        countHouse.Add(houses);
                    }
                }
            }

            countHouse.Sort();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(countHouse.Count.ToString());
            for (int i = 0; i < countHouse.Count; i++)
            {
                sb.AppendLine(countHouse[i].ToString());
            }

            Console.WriteLine(sb);
        }
    }
}
