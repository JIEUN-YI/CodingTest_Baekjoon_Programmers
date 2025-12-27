namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string str_a = sr.ReadLine();
            string str_b = sr.ReadLine();
            string str_c = sr.ReadLine();
            int.TryParse(str_a, out int int_a);
            int.TryParse(str_b, out int int_b);
            int.TryParse(str_c, out int int_c);
            int.TryParse(str_a + str_b, out int add);

            Console.WriteLine(int_a + int_b - int_c);
            Console.WriteLine((add - int_c).ToString());

        }
    }
}
