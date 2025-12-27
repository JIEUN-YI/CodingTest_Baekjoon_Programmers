namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int num);

            // 4의 배수
            if (num % 4 == 0)
            {   // 100의 배수가 아니면
                if (num % 100 != 0) { Console.WriteLine("1"); }
                // 400의 배수
                else if (num % 400 == 0) { Console.WriteLine("1"); }
                else { Console.WriteLine("0"); }
            }
            else { Console.WriteLine("0"); }

        }
    }
}
