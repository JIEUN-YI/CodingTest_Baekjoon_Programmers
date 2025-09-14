using System.Text;

namespace ConsoleStudy
{

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int.TryParse(Console.ReadLine(), out int length);
            string[] input = Console.ReadLine().Split(" ");

            // 사용할 배열을 저장
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                int.TryParse(input[i], out arr[i]);
            }
            int upMax = UpMaxCount(arr);
            int downMax = DownMaxCount(arr);

            int result = Math.Max(upMax, downMax);

            Console.WriteLine(result);

        }

        /// <summary>
        /// 배열의 오름차순을 기준으로 수열의 최대길이를 탐방
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int UpMaxCount(int[] arr)
        {
            int maxLen = 1; // 연속되는 수열의 최대 길이

            for (int index = 0; index < arr.Length; index++)
            {
                int count = 1; // arr[index]로 시작한 수열의 연속 길이
                for (int start = index; start < arr.Length - 1; start++)
                {
                    if (arr[start] <= arr[start + 1])
                    {
                        count++;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                maxLen = Math.Max(maxLen, count); // 두 길이 중 최대값 저장

                // 현재 최대 길이가 앞으로 나올 수 있는 길이보다 크거나 같으면
                if(maxLen >= (arr.Length - 1) - index)
                {
                    return maxLen;
                }
            }
            return maxLen;
        }

        /// <summary>
        /// 배열의 내림차순을 기준으로 수열의 최대길이를 탐방
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int DownMaxCount(int[] arr)
        {
            int maxLen = 1; // 연속되는 수열의 최대 길이
            for (int index = 0; index < arr.Length; index++)
            {
                int count = 1; // arr[index]로 시작한 수열의 연속 길이
                for (int start = index; start < arr.Length - 1; start++)
                {
                    if (arr[start] >= arr[start + 1])
                    {
                        count++;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                maxLen = Math.Max(maxLen, count); // 두 길이 중 최대값 저장
                if (maxLen >= (arr.Length - 1) - index)
                {
                    return maxLen;
                }
            }
            return maxLen;
        }
    }
}