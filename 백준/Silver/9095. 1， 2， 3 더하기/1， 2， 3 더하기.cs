using System.Text;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            // 기본 경우의 수의 합 배열 생성
            int[] Sums = new int[12];
            Sums[0] = 0;
            Sums[1] = 1;
            Sums[2] = 2;
            Sums[3] = 4;

            for(int i = 4;  i < 12; i++)
            {
                Sums[i] = Sums[i - 1] + Sums[i - 2] + Sums[i - 3];
            }
            int.TryParse(sr.ReadLine(), out int count);

            StringBuilder sb = new StringBuilder();
            while(count > 0)
            {
                int.TryParse(sr.ReadLine(), out int num); // 구하려는 값
                sb.AppendLine(Sums[num].ToString());
                count--;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

