using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int.TryParse(sr.ReadLine(), out int count);
            while (count > 0)
            {
                string[] input = sr.ReadLine().Split(" ");
                int.TryParse(input[0], out int value);

                List<int> list = new List<int>(value / 2);
                while (value > 0)
                {
                    list.Add(value);
                    value = value / 2;
                }

                int.TryParse(input[1], out value);

                while (value > 0)
                {
                    if (list.Contains(value))
                    {
                        sb.AppendLine((value * 10).ToString());
                        break;
                    }
                    value = value / 2;
                }
                count--;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
