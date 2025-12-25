namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int[] ints = new int[input.Length];
            for (int index = 0; index < ints.Length; index++)
            {
                int.TryParse(input[index], out ints[index]);
            }
            int sum = 0;
            foreach (int i in ints) { sum += i * i; }
            int answer = sum % 10;
            Console.WriteLine(answer);
        }
    }
}

