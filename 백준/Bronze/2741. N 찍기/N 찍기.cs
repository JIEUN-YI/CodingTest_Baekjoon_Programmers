
using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int.TryParse(sr.ReadLine(), out int num);
            
            for(int i = 1; i <= num; i++)
            {
                sb.AppendLine(i.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
