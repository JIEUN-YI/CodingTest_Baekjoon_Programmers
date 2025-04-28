using System.Collections.Immutable;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] start = Console.ReadLine().Split(" ");
            int.TryParse(start[0], out int N); // 카드의 개수
            int.TryParse(start[1], out int M); // 맞춰야 하는 카드의 합

            string[] startCard = Console.ReadLine().Split(" ");
            int[] cards = new int[N]; // 카드의 숫자 저장

            List<int> cardList = new List<int>(); // M보다 작은 카드의 합을 저장
            for (int i = 0; i < N; i++)
            {
                int.TryParse(startCard[i], out cards[i]);
            }

            for (int first = 0; first < cards.Length - 2; first++)
            {
                for (int second = first + 1; second < cards.Length - 1; second++)
                {
                    for (int third = second + 1; third < cards.Length; third++)
                    {
                        int sum = cards[first] + cards[second] + cards[third];

                        if (sum == M) // M과 동일하면
                        {
                            Console.WriteLine(M);
                            return; // 프로그램 종료
                        }
                        else if (sum < M)
                        {
                            // M보다 작고 리스트에 저장 안된 경우
                            if (!cardList.Contains(sum))
                            {
                                cardList.Add(sum); // M보다 작은 경우 저장
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            // 탐색이 완료된 list에서 가장 M과 차이가 적은 수를 구함
            int[] card = cardList.ToArray();
            Dictionary<int, int> gap = new Dictionary<int, int>(card.Length);
            for(int i = 0; i < card.Length; i++)
            {
                gap.Add(i, M-card[i]);
            }
            gap.TryGetValue(0, out int minNum);
            int index = 0;
            for(int i = 0; i < gap.Count; i++)
            {
                gap.TryGetValue(i, out int num);
                if(num < minNum)
                {
                    minNum = num;
                    index = i;
                }
                else { continue; }
            }
            Console.WriteLine(card[index]);
        }
    }
}