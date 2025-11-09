using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int.TryParse(sr.ReadLine(), out int test); // 테스트 케이스 수

            // 테스트 반복
            while (test > 0)
            {
                int result = 0; // 각 테스트 별 결과값

                string[] input = sr.ReadLine().Split(" ");
                int.TryParse(input[0], out int aLength);
                int.TryParse(input[1], out int bLength);
                string[] a = sr.ReadLine().Split(" ");
                string[] b = sr.ReadLine().Split(" ");

                // A그룹
                int[] groupA = new int[aLength];
                for (int i = 0; i < aLength; i++)
                {
                    int.TryParse(a[i], out groupA[i]);
                }

                // B그룹
                int[] groupB = new int[bLength];
                for (int i = 0; i < bLength; i++)
                {
                    int.TryParse(b[i], out groupB[i]);
                }
                Array.Sort(groupB);

                // 이분 탐색
                foreach (int num in groupA)
                {
                    int high = groupB.Length - 1;
                    int low = 0;
                    int mid = (high + low) / 2;

                    while (low <= high)
                    {
                        // 이분 탐색 로직
                        if (num > groupB[mid])
                        {
                            low = mid + 1;
                            mid = (high + low) / 2;
                        }
                        else
                        {
                            high = mid - 1;
                            mid = (high - low) / 2;
                        }
                    }

                    if (high <= 0)
                    {
                        if(num > groupB[0])
                        {
                            result++;
                            continue;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (num > groupB[high])
                        {
                            result += high + 1;
                            continue;
                        }
                        else
                        {
                            result += high;
                            continue;
                        }
                    }
                }
                sb.AppendLine(result.ToString());
                test--;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}