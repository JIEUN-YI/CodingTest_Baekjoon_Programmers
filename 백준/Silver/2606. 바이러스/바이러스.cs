
using System.Text;

namespace ConsoleStudy
{
    internal class Program
    {
        static int[,] arr; // 인접 행렬 그래프
        static bool[] result; // 연결 여부를 확인할 배열
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int count);

            arr = new int[count, count]; // 인접 행렬 그래프 선언
            int.TryParse(sr.ReadLine(), out int inputCount); // 입력할 횟수

            // 입력을 진행하면서 행렬 그래프 제작
            while (inputCount > 0)
            {
                string[] input = sr.ReadLine().Split(" ");
                arr[int.Parse(input[0]) - 1, int.Parse(input[1]) - 1] = 1;
                arr[int.Parse(input[1]) - 1, int.Parse(input[0]) - 1] = 1;
                inputCount--;
            }

            result = new bool[count]; // 연결 여부를 확인할 배열

            DFS(0); // 1번 컴퓨터에서 탐색 시작

            int sum = 0;
            for(int i =0;i<result.Length; i++)
            {
                if (result[i])
                {
                    sum++;
                }
                else continue;
            }
            sum -= 1; // 자기 자신 제외

            Console.WriteLine(sum.ToString());
        }

        /// <summary>
        /// 깊이 우선 탐색
        /// </summary>
        /// <param name="now"></param>
        private static void DFS(int now)
        {
            result[now] = true; // 방문 표시
            for (int i = 0; i < result.Length; i++) // 모든 경우의 수를 확인
            {
                if (arr[now, i] == 0) // 연결 안된 곳
                {
                    continue;
                }
                if (result[i]) // 이미 방문 한 곳
                {
                    continue;
                }
                DFS(i);
            }
        }
    }
}
