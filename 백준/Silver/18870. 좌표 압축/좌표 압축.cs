using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int count);
            int[] input = new int[count];
            string[] inputArr = sr.ReadLine().Split(" ");
            for (int i = 0; i < count; i++)
            {
                input[i] = int.Parse(inputArr[i]);
            }

            int[] arr = input.Distinct().ToArray(); // 중복을 제거한 새 배열
            Array.Sort(arr); // 정렬

            Dictionary<int,int> dic = new Dictionary<int,int>(); // 검색할 사전 제작
            for(int i = 0; i < arr.Length; i++)
            {
                dic.Add(arr[i], i);// 값 = 인덱스
            }

            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < input.Length; i++)
            {
                if (dic.ContainsKey(input[i]))
                { 
                    dic.TryGetValue(input[i], out int num);
                    sb.Append(num.ToString()+ " ");
                }
            }
            Console.WriteLine(sb.ToString());
        }
        
    }
}