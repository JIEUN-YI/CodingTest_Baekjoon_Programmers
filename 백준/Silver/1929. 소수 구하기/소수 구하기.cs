using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int.TryParse(input[0], out int num1);
            int.TryParse(input[1], out int num2);

            bool[] decimals = new bool[Math.Max(num1, num2) + 1];
            for (int i = 2; i < decimals.Length; i++)
            {
                decimals[i] = true;
            }

            for (int index = 2; index < Math.Sqrt(decimals.Length); index++)
            {
                for (long num = index * index; num < decimals.Length; num += index)
                {
                    decimals[num] = false;
                }
            }

            StringBuilder sb = new StringBuilder();
            for ( int i = num1; i < decimals.Length; i++)
            {
                if (decimals[i]) { sb.AppendLine(i.ToString()); }
            }

            Console.WriteLine(sb.ToString());
        }

    }
}
