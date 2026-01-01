using System.Text;
using System.Xml;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int N);
            int[] input = new int[N];
            for(int i  = 0; i < N; i++)
            {
                int.TryParse(sr.ReadLine(), out input[i]);
            }

            Statictical statictical = new Statictical(N, input);

            Console.WriteLine(statictical.Average());
            Console.WriteLine(statictical.MiddleNum());
            Console.WriteLine(statictical.OffenNum());
            Console.WriteLine(statictical.Range());
        }
    }

    public class Statictical
    {
        public int[] array;
        public int N;

        public Statictical(int inputN, int[] input)
        {
            N = inputN;
            Array.Sort(input);
            array = input;
        }

        public double Average()

        {
            int sum = 0;
            foreach(int i in array)
            {
                sum += i;
            }

            return (int)Math.Round((double)sum / N, 0);
        }

        public int MiddleNum()
        {
            return array[N / 2];
        }

        public int OffenNum()
        {
            Dictionary<int, int> dic = new Dictionary<int, int>(array.Length);
            foreach(int i in array)
            {
                if (dic.ContainsKey(i)) { dic[i]++; }
                else { dic.Add(i, 1); }
            }
            int maxCountNum = dic.Max(x => x.Value);
            int count = 0;
            foreach(int x in dic.Values)
            {
                if(x == maxCountNum) { count++; }
            }

            int result = 0;
            if(count == 1)
            {
                result = dic.FirstOrDefault(x => x.Value == maxCountNum).Key;
            }
            else
            {
                count = 0;
                foreach(int x in dic.Keys)
                {
                    if (dic[x] == maxCountNum) { count++; }
                    if (count == 2)
                    {
                        return x;
                    }
                }
            }
            return result;
        }

        public int Range()
        {
            return array[N - 1] - array[0];
        }
    }
}
