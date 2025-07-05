namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int n); // n 입력 받기
            int[] result = new int[n + 1]; // 결과를 저장할 배열

            // 2 * 2 까지는 지정
            result[0] = 0;
            result[1] = 1;
            if (n >= 2)
            {
                result[2] = 2;

            }

            for (int i = 3; i <= n; i++) // n = 3부터는 n = [n - 1] + [n - 2] 가 성립
            {
                result[i] = (result[i - 1] + result[i - 2]) % 10007;
            }

            Console.WriteLine(result[n]);
        }
    }
}

