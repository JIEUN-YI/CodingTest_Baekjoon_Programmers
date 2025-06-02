using System.Text;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            // 입력값
            int.TryParse(sr.ReadLine(), out int N);

            // 기본 시리즈 숫자
            int series = 666;

            // 0 이상인 입력값
            while (N > 0)
            {
                // 기본 타이틀을 666으로 문자화
                string str = series.ToString();
                if (str.Contains("666")) // 666을 포함하면
                {
                    N--; // N값 감소
                }
                series++; // 시리즈 수 증가
            }
                Console.WriteLine(series-1);
        }
    }
}

