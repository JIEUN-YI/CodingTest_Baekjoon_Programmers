
using System.Buffers;
using System.Text;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            string[] inputNum = sr.ReadLine().Split(" "); // 입력받은 도감의 총 갯수와 문제의 개수
            int.TryParse(inputNum[0], out int count);
            int.TryParse(inputNum[1], out int question);

            // 도감을 두 종류로 제작
            Dictionary<int, string> bookNum = new Dictionary<int, string>(count);
            Dictionary<string, int> bookString = new Dictionary<string, int>(count);
            int index = 1;
            while (count > 0) // Dictionary 로 도감 제작
            {
                string now = sr.ReadLine();
                bookNum.Add(index, now);
                bookString.Add(now, index);
                index++;
                count--;
            }
            StringBuilder sb = new StringBuilder();
            while(question > 0)
            {
                string input = sr.ReadLine(); // 입력 받은 값
                if(int.TryParse(input, out int result)) // 입력 받은 값이 숫자면
                {
                    sb.AppendLine(bookNum[result]);
                }
                else
                {
                    sb.AppendLine(bookString[input].ToString());
                }

                question--;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

