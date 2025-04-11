    public class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int count);

            while (count > 0)
            {
                string[] input = Console.ReadLine().Split(" ");
                int.TryParse(input[0].ToString(), out int repeat);
                List<string> answer = new List<string>();
                foreach (char c in input[1])
                {
                    for (int i = 0; i < repeat; i++)
                    {
                        answer.Add(c.ToString());
                    }
                }
                string result = string.Concat(answer.ToArray());
                Console.WriteLine(result);
                count--;
            }
        }
    }