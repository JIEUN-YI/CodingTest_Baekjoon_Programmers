namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int count = 0;
            foreach (string line in input)
            {
                if(line.Length > 0) { count++; }
            }
            Console.WriteLine(count);
        }
    }
}