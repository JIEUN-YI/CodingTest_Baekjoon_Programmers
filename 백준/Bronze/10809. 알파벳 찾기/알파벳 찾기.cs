using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            string input = sr.ReadLine();
            int[] mapping = new int[26];
            for (int i = 0; i < mapping.Length; i++) { mapping[i] = -1; }
            for (int index = 0; index < input.Length; index++)
            {
                if (mapping[input[index] - 'a'] == -1)
                {
                    mapping[input[index] - 'a'] = index;
                }
            }
            foreach (int index in mapping)
            {
                sb.Append(index + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}