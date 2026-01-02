using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            string[] input = sr.ReadLine().Split(" ");
            int.TryParse(input[0], out int N);
            int.TryParse(input[1], out int X);

            string[] input2 = sr.ReadLine().Split(" ");
            for(int i = 0; i < N; i++)
            {
                int.TryParse(input2[i], out int num);

                if (num < X)
                {
                    sb.Append(num.ToString());
                }
                else { continue; }
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
