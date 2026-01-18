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

                int floor = (N - 1) % H + 1; 
                int roomNum = (N - 1) / H + 1;
                if (roomNum < 10) { sb.AppendLine(floor + "0" + roomNum); }
                else { sb.AppendLine(floor.ToString() + roomNum.ToString()); }

                testCase--;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}