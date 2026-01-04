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
            int.TryParse(input[0], out int A);
            int.TryParse(input[1], out int B);
            int.TryParse(input[2], out int V);
            int findNum = V - B - 1;
            int dayHight = A - B;
            int result = findNum / dayHight;
            int day = (int)result + 1;
            Console.WriteLine(day.ToString());
        }
    }
}