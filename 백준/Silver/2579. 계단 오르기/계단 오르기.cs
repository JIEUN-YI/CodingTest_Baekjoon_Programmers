namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 기본 계단 생성
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int stairCount);
            int[] stairs = new int[stairCount]; // 계단의 점수 배열
            int[] score = new int[stairCount]; // 각 계단까지의 최대합의 점수 배열
            for (int i = 0; i < stairs.Length; i++)
            {
                int.TryParse(sr.ReadLine(), out stairs[i]);
            }

            if(stairCount == 1)
            {
                score[0] = stairs[0];
            }
            else if(stairCount == 2)
            {
                score[0] = stairs[0];
                score[1] = stairs[0] + stairs[1];
            }
            else
            {
                // 계단 3번째까지
                score[0] = stairs[0];
                score[1] = stairs[0] + stairs[1];
                score[2] = Math.Max(stairs[0] + stairs[2], stairs[1] + stairs[2]);

                for (int i = 3; i < score.Length; i++)
                {
                    score[i] = stairs[i];
                    score[i] = Math.Max(score[i - 3] + stairs[i - 1] + stairs[i], score[i - 2] + stairs[i]);
                }
            }
                Console.WriteLine(score[stairCount - 1]);
            
        }
    }
}

