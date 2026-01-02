using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int.TryParse(sr.ReadLine(), out int score);
            if (score >= 90) { Console.WriteLine("A"); }
            else if (score >= 80) { Console.WriteLine("B"); }
            else if (score >= 70) { Console.WriteLine("C"); }
            else if(score >= 60) { Console.WriteLine("D"); }
            else { Console.WriteLine("F"); }
        }
    }
}
