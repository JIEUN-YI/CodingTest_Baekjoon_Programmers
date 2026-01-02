namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            bool isCheck = false;
            if (input[0] == "1")
            {
                int count = 1;
                foreach (string s in input)
                {
                    if (s == count.ToString()) { isCheck = true; count++; continue; }
                    else { Console.WriteLine("mixed"); isCheck = false; break; }
                }
                if (isCheck)
                {
                    Console.WriteLine("ascending");
                }
            }
            else if (input[0] == "8")
            {
                int count = 8;
                foreach (string s in input)
                {
                    if (s == count.ToString()) { isCheck = true; count--; continue; }
                    else { Console.WriteLine("mixed"); isCheck = false; break; }
                }
                if (isCheck)
                {
                    Console.WriteLine("descending");
                }
            }
            else
            {
                Console.WriteLine("mixed");
            }
        }
    }
}