using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;
using System.Timers;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int count);
            string[] input = sr.ReadLine().Split();

            int[] priority = new int[input.Length]; // 우선 순위 배열 제작
            for (int i = 0; i < input.Length; i++)
            {
                priority[i] = int.Parse(input[i]);
            }

            Array.Sort(priority); // 오름차순 순서대로 정렬

            int sum = 0;
            for(int i = 0; i < count; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    sum += priority[j]; // 모든 우선순위의 합
                }
            }

            Console.WriteLine(sum);
        }
    }
}
