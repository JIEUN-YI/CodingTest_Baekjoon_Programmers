using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int.TryParse(sr.ReadLine(), out int N);

            int result = 999999999;

            for(int find = N; find > 0; find--)
            {
                int candidate = find;
                int sum = find;
                while (candidate > 0)
                {
                    sum += candidate % 10;
                    candidate /= 10;
                }
                if (sum == N)
                {
                    result = Math.Min(result, find);
                }
                else continue;
            }
            if (result == 999999999) { Console.WriteLine(0); }
            else { Console.WriteLine(result); }
        }
    }
}
