using System.Buffers;
using System.Text;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int count);
            int num = 0;
            // 새로운 자료형으로 배열 생성
            Body[] bodies = new Body[count];
            while (count > 0) // 배열 저장
            {
                string[] input = sr.ReadLine().Split(" ");
                int.TryParse(input[0], out int weight);
                int.TryParse(input[1], out int height);
                Body person = new(weight, height);
                bodies[num] = person;
                num++;
                count--;
            }
            int[] result = new int[bodies.Length];
            // 배열을 돌면서 비교
            for(int i = 0; i < bodies.Length; i++)
            {
                int rank = 1;
                for (int j = 0; j < bodies.Length; j++)
                {
                    // j의 덩치가 큰 경우
                    if(bodies[i].weight < bodies[j].weight && bodies[i].height < bodies[j].height)
                    {
                       rank++;
                    }
                    else
                    {
                        continue;
                    }
                }
                result[i] = rank;
            }
            StringBuilder sb = new StringBuilder();
            foreach( int nu in result)
            {
                sb.Append(nu+" ");
            }
            Console.WriteLine(sb.ToString());
        }

    }
    public class Body
    {
        public int weight;
        public int height;
        public Body(int weight, int height)
        {
            this.weight = weight;
            this.height = height;
        }
    }
}

