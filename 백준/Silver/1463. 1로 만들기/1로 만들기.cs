using System.Runtime.Intrinsics.Arm;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 기본 배열 생성
            int[] counts = new int[1000001];
            counts[0] = 0;
            counts[1] = 0;
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int num);
            for (int i = 2; i <= num; i++)
            {
                counts[i] = counts[i - 1] + 1; // 기본 시작

                if (i % 2 == 0) // 2의 배수 일 때
                {
                    counts[i] = Math.Min(counts[i / 2] + 1, counts[i]); // 현재 count[i]와 2로 나누어서 시작한 수의 최소값
                }

                if (i % 3 == 0) // 3의 배수
                {
                    counts[i] = Math.Min(counts[i / 3] + 1, counts[i]); // 현재 counts[i]와 3으로 나누어서 시작한 수의 최소값
                }
            }

            Console.WriteLine(counts[num]);
        }
    }
}

