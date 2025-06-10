namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int.TryParse(input[0], out int N);
            int.TryParse(input[1], out int K);

            int[] coins = new int[N]; // 가지고 있는 동전의 배열
            int index = 0;
            while (N > 0) // 가지고 있는 동전의 배열 제작
            {
                int.TryParse(sr.ReadLine(), out int coin);
                coins[index] = coin;
                N--;
                index++;
            }
            Array.Sort(coins); // 내림차순 정렬
            Array.Reverse(coins);

            int count = 0;

            for (int i = 0; i < coins.Length; i++)
            {
                if (K - coins[i] < 0) // 음수인 경우 패스
                {
                    continue;
                }
                else if (K - coins[i] >= 0) // 양수인 경우
                {
                    count += K / coins[i]; // 최대로 필요한 개수
                    K -= ((K / coins[i]) * coins[i]); // 나머지 값
                    if (K == 0)
                    {
                        break;
                    }
                    continue;
                }
            }
            Console.WriteLine(count);
        }
    }
}

