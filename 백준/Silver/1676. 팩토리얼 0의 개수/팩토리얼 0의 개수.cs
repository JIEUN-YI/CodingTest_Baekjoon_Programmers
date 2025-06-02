using System.Text;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int.TryParse(sr.ReadLine(), out int num); // 숫자 입력

            int result = 0;
            while (num > 4)
            {
                num /= 5;
                result += num;
            }
            Console.WriteLine(result);
        }
    }
}

