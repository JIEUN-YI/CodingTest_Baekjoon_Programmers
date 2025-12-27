namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int.TryParse(input[0], out int H);
            int.TryParse(input[1], out int M);

            if (M < 45)
            {
                H--;
                M = (M + 60) - 45;
            }
            else { M -= 45; }

            if (H < 0) { H = 24 + H; }

            Console.WriteLine($"{H} {M}");
        }
    }
}
