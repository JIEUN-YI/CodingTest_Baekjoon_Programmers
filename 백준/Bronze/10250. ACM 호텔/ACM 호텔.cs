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
                string[] input = sr.ReadLine().Split(" ");
                int.TryParse(input[0], out int H); // 층수
                int.TryParse(input[1], out int W); // 방수
                int.TryParse(input[2], out int N); // 몇번째 손님
                for (int x = 0; x < W; x++)
                {
                    for (int y = 0; y < H; y++)
                    {
                        N--;
                        if (N == 0)
                        {
                            if (x + 1 < 10)
                            {
                                sb.Append(y + 1);
                                sb.Append(0);
                                sb.Append(x + 1);
                            }
                            else
                            {
                                sb.Append(y + 1);
                                sb.Append(x + 1);
                            }
                            break;
                        }
                    }
                }
                sb.AppendLine();
                testCase--;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}