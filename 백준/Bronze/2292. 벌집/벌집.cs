namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int N);

            // 시작 하는 줄
            int line = 1;
            // 줄의 시작 값
            int start = 0;
            // 줄의 끝 값
            int end = 1;

            while (end < N)
            {
                start += end;
                end += 6 * line;
                line++;
            }
            Console.WriteLine(line);
        }

    }
}
