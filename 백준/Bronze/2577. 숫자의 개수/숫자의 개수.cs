using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int A);
            int.TryParse(sr.ReadLine(), out int B);
            int.TryParse(sr.ReadLine(), out int C);

            long multiply = A * B * C;

            string find = multiply.ToString();
            int[] compare = new int[10];
            foreach (char c in find)
            {
                compare[c - 48] += 1;
            }

            StringBuilder sb = new StringBuilder();
            foreach (int result in compare) { sb.AppendLine(result.ToString()); }

            Console.WriteLine(sb.ToString());
        }
    }
}