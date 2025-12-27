
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
            
            for(int y = 1; y <= num; y++)
            {
                for(int x = num; x > 0; x--)
                {
                    if (x <= y) { sb.Append("*"); }
                    else { sb.Append(" "); }
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
