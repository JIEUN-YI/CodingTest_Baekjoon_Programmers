using System.Buffers;
using System.Text;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int.TryParse(input[0], out int num);
            int.TryParse(input[1], out int count);
            Dictionary<string, string> dic = new Dictionary<string, string>(num); // num 개로 검색할 Dictionary 제작

            // Dictionary 작성
            while(num > 0)
            {
                string[] inputIP = sr.ReadLine().Split(" ");
                dic.Add(inputIP[0], inputIP[1]); // 주소 = Key
                num--;
            }

            StringBuilder sb = new StringBuilder(); // 검색 값 저장
            // 검색
            while(count > 0)
            {
                string search = sr.ReadLine(); // 입력받은 주소
                sb.AppendLine(dic[search]);
                count--;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

