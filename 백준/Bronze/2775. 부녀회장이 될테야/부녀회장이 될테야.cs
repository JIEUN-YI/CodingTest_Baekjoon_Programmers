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
                int.TryParse(sr.ReadLine(), out int floor);
                int.TryParse(sr.ReadLine(), out int registerNum);

                int[,] mantion = new int[floor + 1, registerNum + 1];

                for (int x = 1; x < mantion.GetLength(1); x++)
                {
                    mantion[0, x] = x;
                }

                for (int y = 1; y < mantion.GetLength(0); y++)
                {
                    for (int x = 1; x < mantion.GetLength(1); x++)
                    {
                        int sum = 0;
                        for (int count = 1; count <= x; count++)
                        {
                            sum += mantion[y - 1, count];
                        }
                        mantion[y, x] = sum;
                    }
                }
                sb.AppendLine(mantion[floor, registerNum].ToString());
                testCase--;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}