using System.Text;

namespace ConsoleStudy
{
    internal class Program
    {
        private class Set
        {
            public int countZero;
            public int countOne;
            public Set(int countZero, int countOne)
            {
                this.countZero = countZero;
                this.countOne = countOne;
            }
        }


        static Set[] sets = new Set[50];
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int.TryParse(sr.ReadLine(), out int count);
            FiboMemo(40);
            while (count > 0)
            {
                int.TryParse(sr.ReadLine(), out int num);
                sb.AppendLine(sets[num].countZero + " " + sets[num].countOne);
                count--;
            }
            Console.WriteLine(sb.ToString());
        }
        private static Set[] FiboMemo(int n)
        {
            sets[0] = new Set(1, 0);
            sets[1] = new Set(0, 1);

            int countZero = 0;
            int countOne = 0;
            for(int i = 2; i <= n; i++)
            {
                sets[i] = new Set(sets[i-1].countZero+sets[i-2].countZero, sets[i - 1].countOne + sets[i - 2].countOne); 
            }
            return sets;
        }
    }
}

