using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int count);
            int index = 0;
            Coordinates[] arr = new Coordinates[count];
            while (count > 0)
            {
                string[] input = sr.ReadLine().Split(" ");
                long.TryParse(input[0], out long x);
                long.TryParse(input[1], out long y);

                Coordinates now = new Coordinates(x, y);
                arr[index] = now;

                index++;
                count--;
            }
            
            Array.Sort(arr, (a, b) =>
            {
                if (a.x < b.x) // a.x가 작으면 -1을 반환하며 b, a로 정렬 = 작은 수가 앞으로 정렬됨
                {
                    return -1;
                }
                else if (a.x > b.x)
                {
                    return 1;
                }
                else
                {
                    if (a.y < b.y)
                    {
                        return -1;
                    }
                    else if (a.y > b.y)
                    {
                        return 1;
                    }
                    else
                        return 1;
                }
            });

            StringBuilder sb = new StringBuilder();
            foreach(Coordinates now in arr)
            {
                sb.Append(now.x + " " + now.y + "\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }
    
    class Coordinates
    {
        public long x;
        public long y;

        public Coordinates(long x, long y)
        {
            this.x = x;
            this.y = y;
        }
    }
}