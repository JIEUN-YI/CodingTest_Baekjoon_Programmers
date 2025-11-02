using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int n);
            string[] input = sr.ReadLine().Split(" ");
            int[] have = new int[n];
            // 가지고 있는 숫자 카드
            for (int i = 0; i < input.Length; i++)
            {
                int.TryParse(input[i], out have[i]);
            }
            Array.Sort(have); // 가지고 있는 카드 정렬

            int.TryParse(sr.ReadLine(), out int M);
            int[] find = new int[M];
            string[] input2 = sr.ReadLine().Split(" ");
            
            // 가지고 있는지 확인할 카드 목록
            for (int i = 0; i < input2.Length; i++)
            {
                int.TryParse(input2[i], out find[i]);
            }

            StringBuilder sb = new StringBuilder();

            // 이진탐색
            foreach (int num in find)
            {
                // 인덱스로 확인
                int low = 0;
                int high = have.Length - 1;
                int mid = (high + low) / 2;
                bool isCheck = false;
                // 이분탐색으로 num을 have가 가지고 있는지 탐색
                while (low <= high)
                {
                    if (num == have[mid])
                    {
                        isCheck = true;
                        break;
                    }
                    else if (num < have[mid])
                    {
                        high = mid - 1;
                        mid = (high + low) / 2;
                    }
                    else
                    {
                        low = mid + 1;
                        mid = (high + low) / 2;
                    }
                }

                if (isCheck) { sb.Append("1 "); }
                else { sb.Append("0 "); }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}