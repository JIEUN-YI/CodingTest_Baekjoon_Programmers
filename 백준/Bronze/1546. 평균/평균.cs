using System.Collections.Immutable;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int count);
            string[] answer = Console.ReadLine().Split(" ");
            int[] score = new int[count];
            for(int i = 0; i < answer.Length; i++)
            {
                int.TryParse(answer[i], out score[i]);
            }

            Array.Sort(score); // 점수를 정렬
            int maxScore = score[count-1]; // 가장 큰 값

            // 소수점까지 포함하는 숫자
            double sum = 0;
            for(int i = 0; i < score.Length; i++)
            {
                sum += (double)score[i] / (double)maxScore * 100;
            }
            double result = sum / count;

            Console.WriteLine(result.ToString());
        }
    }
}