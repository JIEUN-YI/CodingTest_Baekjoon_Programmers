using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int.TryParse(sr.ReadLine(), out int test);
            while (test > 0)
            {
                int.TryParse(sr.ReadLine(), out int size);
                string[] input = sr.ReadLine().Split(" ");
                Cycle cycle = new Cycle(size, input);
                sb.AppendLine(cycle.MakeCycle().ToString()); // 만들어진 사이클의 개수
                test--;
            }

            Console.WriteLine(sb.ToString());
        }
    }

    public class Cycle
    {
        public Dictionary<int, int> dataDic; // 입력받은 데이터
        private bool[] visited; // 방문여부확인
        private List<LinkedList<int>> makeCycle; // 만든 사이클 리스트

        public Cycle(int size, string[] input)
        {
            dataDic = new Dictionary<int, int>(size);
            visited = new bool[size];
            makeCycle = new List<LinkedList<int>>();
            int key = 1;
            while (size > 0)
            {
                dataDic.Add(key, int.Parse(input[key - 1]));
                key++;
                size--;
            }
        }

        public int MakeCycle()
        {
            for (int index = 0; index < dataDic.Count; index++)
            {
                if (visited[index])
                {
                    continue;
                }
                else
                {
                    LinkedList<int> cycle = new LinkedList<int>();
                    int nowKey = index + 1; // 현재 탐색 키

                    while (!visited[nowKey - 1]) // 연결이 이어지면
                    {
                        visited[nowKey - 1] = true; // 현재 탐색 완료
                        cycle.AddLast(dataDic[nowKey]); // 사이클에 현재 탐색 값 저장
                        nowKey = dataDic[nowKey];
                    }
                    makeCycle.Add(cycle);
                }
            }

            return makeCycle.Count;
        }
    }

}