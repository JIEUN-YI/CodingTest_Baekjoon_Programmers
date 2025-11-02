namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int.TryParse(input[0], out int N);
            int.TryParse(input[1], out int M);
            int[] cost = new int[N];

            for (int ind = 0; ind < N; ind++)
            {
                int.TryParse(sr.ReadLine(), out cost[ind]);
            }
            int high = cost.Sum();
            int low = cost.Max();
            if (M == 1)
            {
                Console.WriteLine(high);
            }
            else
            {
                int mid = (high + low) / 2;

                while (low < high)
                {
                    int outCount = 1; // 인출 횟수
                    int balance = mid; //잔액

                    foreach (int ind in cost)
                    {
                        if (ind < balance) // 잔액에서 뺄 수 있는 경우
                        {
                            balance -= ind;
                        }
                        else if (ind > balance) // 잔액 부족으로 인출하는 경우
                        {
                            outCount++;
                            balance = mid - ind;
                        }
                        else // 잔액을 전부 쓴 경우
                        {
                            balance = mid; // 다음 잔액 인출
                            outCount++;
                        }
                    }

                    if (outCount > M)
                    {
                        low = mid + 1;
                        mid = (high + low) / 2;
                    }
                    else
                    {
                        high = mid - 1;
                        mid = (high + low) / 2;
                    }
                }

                Console.WriteLine(low);
            }
        }

    }

}