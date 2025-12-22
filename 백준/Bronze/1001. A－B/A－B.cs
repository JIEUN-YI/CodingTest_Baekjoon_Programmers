
using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            string[] input = sr.ReadLine().Split(" ");
            int.TryParse(input[0], out int a); 
            int.TryParse(input[1], out int b);

            Console.WriteLine((a - b).ToString());
        }
    }
}
