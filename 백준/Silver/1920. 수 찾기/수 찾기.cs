using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int ACount);
            string[] input = Console.ReadLine().Split(" ");
            int[] basic = new int[ACount]; // 배열로 기본 배열 입력
            for (int i = 0; i < input.Length; i++)
            {
                int.TryParse(input[i], out basic[i]);
            }
            // 배열 정렬
            Array.Sort(basic);

            int.TryParse(Console.ReadLine(), out int MCount);
            string[] input2 = Console.ReadLine().Split(" ");
            int[] comparison = new int[MCount]; // 배열로 제작
            for (int i = 0; i < comparison.Length; i++)
            {
                int.TryParse(input2[i], out comparison[i]);
            }

            StringBuilder resultStr = new StringBuilder();

            foreach(int i in comparison)
            {
                resultStr.Append(BinarySearch(basic, i)+"\n");
            }

            Console.WriteLine(resultStr);
        }

        public static int BinarySearch(int[] arr, int value)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2; // 이진 탐색을 위한 중간 값
                if(arr[mid] == value)
                {
                    return 1;
                }
                else if(arr[mid] < value) // 찾는 값이 중간값보다 작은 경우
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return 0;
        }
    }
}