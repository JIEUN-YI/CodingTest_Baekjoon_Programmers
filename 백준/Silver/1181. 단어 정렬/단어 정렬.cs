namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int count);
            List<string> list = new List<string>(count);
            int index = 0;
            while (count > 0)
            {
                string answer = Console.ReadLine();
                if (!list.Contains(answer))
                {
                    list.Add(answer);
                    count--;
                }
                else
                {
                    count--;
                }
            }

            list.Sort((x, y) =>
            {
                if (x.Length > y.Length)
                {
                    return 1;
                }
                else if (x.Length < y.Length)
                {
                    return -1;
                }
                else
                {
                    return String.Compare(x, y);
                }
            });
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}