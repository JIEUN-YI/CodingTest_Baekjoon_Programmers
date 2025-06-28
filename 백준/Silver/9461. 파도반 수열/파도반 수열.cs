using System.Text;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            long[] series = new long[101];
            series[0] = 0;
            series[1] = 1;
            series[2] = 1;
            for(int i = 3; i < series.Length; i++)
            {
                series[i] = series[i - 3] + series[i - 2];
            }
            
            int.TryParse(sr.ReadLine(), out int test);
            while (test > 0)
            {
                int.TryParse(sr.ReadLine(), out int index); // 입력한 인덱스의 수열 값
                sb.AppendLine(series[index].ToString()); // 결과 저장
                test--;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

