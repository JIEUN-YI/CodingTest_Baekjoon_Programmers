
using static System.Net.WebRequestMethods;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int count);
            
            // 앞 뒤로 제거할 숫자의 갯수
            int balance = (int)Math.Round(count * 0.15f, MidpointRounding.AwayFromZero);
            
            // 배열의 인덱스 범위
            // int front = balance - 1;
            int back = count - balance;

            // 입력받은 숫자들
            int[] input = new int[count];
            int index = 0;


            if(count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                while (count > 0)
                {
                    int.TryParse(sr.ReadLine(), out input[index]);
                    count--;
                    index++;
                }
            }
            Array.Sort(input);
            
            // 결과에 필요한 배열 제작
            int[] resultArr = input[balance..back];

            int sum = 0;
            for(int i = 0; i < resultArr.Length; i++)
            {
                sum += resultArr[i];
            }

            double n = (double)sum / (double)resultArr.Length;
            int average = (int)Math.Round(n, MidpointRounding.AwayFromZero);
            Console.WriteLine(average.ToString());
        }
    }
}

