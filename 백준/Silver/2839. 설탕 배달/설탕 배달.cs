using System.Text;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int.TryParse(sr.ReadLine(), out int kg);
            int result = 0;
            int count = kg / 5;
            while (count >= 0)
            {
                int num = 5 * count;
                if ((kg - num) % 3 == 0) // 5kg를 채우고 난 나머지가 3의 배수인 경우
                {
                    result = count;
                    kg -= (5 * count);
                    result += kg / 3;
                    sb.Append(result);
                    break;
                }
                else
                {
                    count--;
                }
            }
            if(result == 0)
            {
                sb.Append(-1);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}