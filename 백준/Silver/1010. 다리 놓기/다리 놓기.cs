using System.Text;

namespace ConsoleStudy
{

    class Program
    {
        static void Main(string[] args)
        {
            long[,] arr = new long[31, 31];
            for(int x = 1; x < arr.GetLength(1); x++)
            {
                arr[1, x] = x;
            }
            for(int y= 2; y < arr.GetLength(0); y++)
            {
                for (int x = 1; x < arr.GetLength(1); x++)
                {
                    if (y == x)
                    {
                        arr[y, x] = 1;
                    }
                    else
                        arr[y, x] = arr[y - 1, x - 1] + arr[y, x - 1];
                }
            }

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int.TryParse(sr.ReadLine(), out int test);
            while(test > 0)
            {
                string[] input = sr.ReadLine().Split(" ");

                int.TryParse(input[0], out int y);
                int.TryParse(input[1], out int x);

                sb.AppendLine(arr[y, x].ToString());
                test--;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}