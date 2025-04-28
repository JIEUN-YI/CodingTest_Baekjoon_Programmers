namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] answer = Console.ReadLine().Split(" ");
            int.TryParse(answer[0], out int N);
            int.TryParse(answer[1], out int k);

            int molecule = 1;
            // 분자 값
            for(int i = 1; i <= N; i++)
            {
                molecule *= i;
            }
            // 분모 값
            int denominator = 1;
            for( int i = 1; i <= N-k; i++)
            {
                denominator *= i;
            }
            for(int i = 1; i <= k; i++)
            {
                denominator *= i;
            }
            Console.WriteLine((molecule / denominator));
        }
    }
}