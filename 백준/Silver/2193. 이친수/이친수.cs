using System.Text;

namespace ConsoleStudy
{

    class Program
    {
        static void Main(string[] args)
        {
            long[] twoCrazy = new long[91];
            twoCrazy[0] = 0;
            twoCrazy[1] = 1;
            twoCrazy[2] = 1;
            twoCrazy[3] = 2;
            // 피보나치 규칙을 사용해, 90까지의 이친수를 미리 저장
            for(int index = 4; index < twoCrazy.Length; index++)
            {
                twoCrazy[index] = twoCrazy[index - 2] + twoCrazy[index - 1];
            }

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(Console.ReadLine(), out int num);

            Console.WriteLine(twoCrazy[num]);

        }

        
    }
}