using System.Data;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            DataTable dt = new DataTable();
            int result = 0; // 출력할 결과
            string[] input = sr.ReadLine().Split("-"); // 입력받아 -를 기준으로 식을 분할

            List<int> output = new List<int>(); // 합연산을 완료한 리스트

            for(int index = 0; index < input.Length; index++)
            {
                output.Add((int)dt.Compute(input[index], ""));
            }
            // output 리스트의 각 연산을 - 연산 진행
            result = output[0];
            for(int index = 1;index < output.Count; index++)
            {
                result-=output[index];
            }
            Console.WriteLine(result);
        }
    }
}