using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int count);
            int[] numbers = new int[count];
            int index = 0;
            while (count > 0)
            {
                int.TryParse(Console.ReadLine(), out numbers[index]);
                count--;
                index++;
            }

            StringBuilder sb = new StringBuilder();

            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                sb.Append(i + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}