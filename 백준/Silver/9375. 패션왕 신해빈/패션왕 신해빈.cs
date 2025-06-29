using System.Text;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int.TryParse(sr.ReadLine(), out int testCount); // 테스트 케이스 수

            while (testCount > 0)
            {
                int.TryParse(sr.ReadLine(), out int num); // 입력할 수
                Dictionary<string, int> typeDic = new Dictionary<string, int>(num); // 옷의 종류와 그 개수

                while (num > 0) // 입력 받아 의상의 종류를 Dictionary와 배열 저장
                {
                    string[] inputs = sr.ReadLine().Split(" ");
                    if (!typeDic.ContainsKey(inputs[1])) // dic에 종류가 없으면
                    {
                        typeDic.Add(inputs[1], 1); // 개수 추가
                        num--;
                    }
                    else // 종류가 있으면
                    {
                        typeDic[inputs[1]]++; // 개수 추가
                        num--;
                    }
                }
                int[] counts = new int[typeDic.Count]; // 개수 배열 제작
                int index = 0;
                foreach (int value in typeDic.Values) // 개수 채우기
                {
                    counts[index] = value + 1; // 안입은 경우를 포함하기 위해 + 1
                    index++;
                }

                int result = 1;
                foreach (int value in counts)
                {
                    result *= value; // 모든 선택의 경우의 수
                }
                result -= 1; // 모두 안입은 경우를 제거

                sb.AppendLine(result.ToString()); // 결과 저장

                testCount--;
            }
            Console.WriteLine(sb);
        }
    }
}

