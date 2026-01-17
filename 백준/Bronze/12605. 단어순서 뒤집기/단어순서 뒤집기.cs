using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int testCase);
            StringBuilder sb = new StringBuilder();

            int caseNum = 1;
            while (testCase > 0)
            {
                string[] input = sr.ReadLine().Split(" ");
                Array.Reverse(input);
                string now = String.Join(" ", input);
                sb.AppendLine($"Case #{caseNum}: " + now);
                caseNum++;
                testCase--;
            }
            Console.Write(sb);
        }
    }
}
