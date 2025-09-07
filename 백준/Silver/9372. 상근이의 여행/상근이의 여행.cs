using System.Dynamic;
using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int.TryParse(sr.ReadLine(), out int test);
            while (test > 0)
            {
                string[] input = sr.ReadLine().Split(" ");
                int.TryParse(input[0], out int num1);
                int.TryParse(input[1], out int num2);
                while (num2 > 0)
                {
                    string[] flight = sr.ReadLine().Split(" ");
                    int.TryParse(input[0], out int flight1);
                    int.TryParse(input[1], out int flight2);
                    num2--;
                }
                int result = num1 - 1;
                sb.AppendLine(result.ToString());
                test--;
            }

            Console.WriteLine(sb.ToString());

        }
    }
}