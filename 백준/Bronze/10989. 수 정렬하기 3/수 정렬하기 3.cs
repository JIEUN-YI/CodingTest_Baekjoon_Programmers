using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            int.TryParse(sr.ReadLine(), out int count);
            int[] arr = new int[10001];
            while (count > 0)
            {
                int.TryParse(sr.ReadLine(), out int index);
                arr[index]++;
                count--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int num = 0; num < arr[i]; num++)
                {
                    sw.WriteLine(i);
                }
            }
            sw.Flush();
        }
    }
}