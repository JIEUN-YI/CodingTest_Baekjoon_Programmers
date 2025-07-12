using System.Data;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int.TryParse(input[0], out int K); // 이미 가진 랜선의 개수
            int.TryParse(input[1], out int N); // 필요한 랜선의 개수
            int[] lines = new int[K+1];
            lines[0] = 1;
            for(int index = 1; index <= K; index++)
            {
                int.TryParse(sr.ReadLine(), out int line);
                lines[index] = line;
            }
            Array.Sort(lines); // 배열 정렬

            long low = 1;
            long high = lines.Max(); // 있는 랜선 중 최대값
            // 이분 탐색
            while(low<= high) // low > high가 되면 종료
            {
                long mid = (low+high) / 2; // 중간 값 구하기
                long countLan = 0; // 랜선의 개수
                foreach(int line in lines)
                {
                    countLan += line / mid; // 나눈 랜선의 개수를 전부 더함
                }
                if(countLan >= N) // 필요한 랜선의 개수 이상 제작되는 경우
                {
                    low = mid + 1;
                }
                else // 적게 제작되는 경우
                {
                    high = mid - 1;
                }
            }
            // while문이 끝날때의 high 값이 랜선의 길이
            Console.WriteLine(high);
        }
    }
}