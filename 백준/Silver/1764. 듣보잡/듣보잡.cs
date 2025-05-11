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

            string[] inputNum = sr.ReadLine().Split(" ");

            Dictionary<string, bool> result = new Dictionary<string, bool>(); // 입력받은 이름의 듣도보도 못한 여부
            List<string> list = new List<string>();

            // 듣지 못한 이름 입력
            for(int i = 0; i < int.Parse(inputNum[0]); i++)
            {
                result.Add(sr.ReadLine(), true);
            }

            for(int i =0; i < int.Parse(inputNum[1]); i++)
            {
                string inputName = sr.ReadLine();
                if (result.ContainsKey(inputName))
                {
                    list.Add(inputName);
                }
                else // 없는 경우는 넘어가기
                {
                    continue;
                }
            }

            list.Sort(); // 사전식 정렬

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(list.Count.ToString());
            foreach(string s in list)
            {
                sb.AppendLine(s);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
