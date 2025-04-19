using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>(20000000);
            for(int i = -10000000; i < 10000001; i++)
            {
                keyValues.Add(i, 0);
            }

            int.TryParse(Console.ReadLine(), out int haveCount);
            string[] haveAnswer = Console.ReadLine().Split(" ");
            int[] haveCard = new int[haveCount]; // 상근이가 가진 카드의 번호
            foreach (string a in haveAnswer)
            {
                int.TryParse(a, out int card);
                keyValues[card] = keyValues[card] + 1;
            }


            int.TryParse(Console.ReadLine(), out int count);
            string[] cardAnswer = Console.ReadLine().Split(" ");
            int[] cards = new int[count]; // 상근이가 가지고 있는지 개수를 확인할 카드의 번호

            StringBuilder sb = new StringBuilder();
            foreach (string a in cardAnswer)
            {
                int.TryParse(a, out int card);
                if (keyValues.ContainsKey(card))
                {
                    sb.Append(keyValues[card]+" ");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

