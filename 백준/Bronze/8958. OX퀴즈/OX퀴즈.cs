using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int.TryParse(sr.ReadLine(), out int testCase);
            while (testCase > 0)
            {
                int score = 1;
                int sum = 0;
                string input = sr.ReadLine();
                foreach (char s in input)
                {
                    if (s == 'O') { sum += score; score++; }
                    else { score = 1; }
                }
                sb.AppendLine(sum.ToString());
                testCase--;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}