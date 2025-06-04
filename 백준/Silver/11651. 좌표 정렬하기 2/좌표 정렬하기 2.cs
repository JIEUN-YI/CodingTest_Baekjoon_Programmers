using System.Text;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int count);
            Vector[] vectors = new Vector[count];
            int index = 0;
            while (count > 0)
            {
                string[] input = sr.ReadLine().Split(" ");
                int.TryParse(input[0], out int x);
                int.TryParse(input[1], out int y);
                Vector now = new Vector(x, y);
                vectors[index] = now;
                index++;
                count--;
            }

            Array.Sort(vectors, (x, y) =>
            {
                if (x.y < y.y)
                {
                    return -1;
                }
                else if (x.y == y.y)
                {
                    if (x.x < y.x)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return 1;
                }
            });

            StringBuilder sb = new StringBuilder();
            foreach (Vector v in vectors)
            {
                sb.AppendLine(v.x + " " + v.y);
            }
            Console.WriteLine(sb.ToString());
        }
        class Vector
        {
            public int x;
            public int y;
            public Vector(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}

