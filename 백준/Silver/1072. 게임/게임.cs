namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            string[] inputs = sr.ReadLine().Split(" ");
            long.TryParse(inputs[0], out long X); // 자료형 범위 주의
            long.TryParse(inputs[1], out long Y);

            // 현재 확률
            int Z = (int)((Y * 100 / X));
            int newZ = 0;

            // X의 최대값
            int high = 1000000000;
            int low = 0;
            int mid = (high + low) / 2;

            while (low <= high)
            {
                mid = (high + low) / 2;
                newZ = (int)((Y + mid) * 100 / (X + mid));

                if (newZ <= Z)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            if (Z >= 99) { Console.WriteLine(-1); } // 확률이 99프로 이상이면 변동 불가능
            else { Console.WriteLine(low); }

        }
    }
}