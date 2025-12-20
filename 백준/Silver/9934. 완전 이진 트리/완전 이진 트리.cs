using System.Net.Http.Headers;
using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            Building building = new Building();
            building.depth = 0;

            int.TryParse(sr.ReadLine(), out int K);
            string[] input = sr.ReadLine().Split(" "); // 입력받은 노드
            int[] ints = new int[input.Length];
            for (int ind = 0; ind < ints.Length; ind++)
            {
                int.TryParse(input[ind], out ints[ind]);
            }

            building.Divied(ints, 0, ints.Length, 0);
            sb = building.ShowOff();
            Console.WriteLine(sb.ToString());
        }


    }

    public class Building
    {
        public int depth; // 깊이
        public int[] BulidList; // 건물 번호
        public Dictionary<int, List<int>> Result = new Dictionary<int, List<int>>(); // int = 깊이, List<int> 해당 깊이의 건물 번호 리스트

        public void Divied(int[] arr, int start, int end, int depth)
        {
            if (start >= end)
            {
                return;
            }

            int mid = (start + end) / 2;
            if (Result.ContainsKey(depth))
            {
                Result[depth].Add(arr[mid]);
            }
            else
            {
                Result.Add(depth, new List<int>());
                Result[depth].Add(arr[mid]);
            }
            Divied(arr, start, mid, depth + 1);
            Divied(arr, mid + 1, end, depth + 1);
        }

        public StringBuilder ShowOff()
        {
            StringBuilder sb = new StringBuilder();
            foreach(List<int> list in Result.Values)
            {
                foreach(int num in list)
                {
                    sb.Append(num+" ");
                }
                sb.AppendLine();
            }
            return sb;
        }
    }
}
