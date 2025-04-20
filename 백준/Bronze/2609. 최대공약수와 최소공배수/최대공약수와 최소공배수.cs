namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] answer = Console.ReadLine().Split(" ");
            int.TryParse(answer[0], out int a);
            int.TryParse(answer[1], out int b);
            if (a == b)
            {
                Console.WriteLine(a);
                Console.WriteLine(a);
            }
            else
            {
                int[] num1 = DivisorNum(a);
                int[] num2 = DivisorNum(b);
                int maxMeasureNum = MaxMeasure(num1, num2);

                int restA = a / maxMeasureNum;
                int restB = b / maxMeasureNum;

                int minMultiple = maxMeasureNum * restA * restB;

                Console.WriteLine(maxMeasureNum);
                Console.WriteLine(minMultiple);
            }
        }
        /// <summary>
        /// 수의 약수를 구하여 배열로 출력
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int[] DivisorNum(int num)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1); // 1과 자기자신을 저장
            numbers.Add(num);

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    if (!numbers.Contains(i)) // 중복이 없도록
                    {
                        numbers.Add(i);
                        numbers.Add(num / i);
                        continue;
                    }
                }
            }

            int[] result = numbers.ToArray(); // 배열로 변경하어
            Array.Sort(result); // 정렬
            return result;
        }
        /// <summary>
        /// 수의 최대공약수를 구하여 리턴
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int MaxMeasure(int[] num1, int[] num2)
        {
            int maxNum = 0; // 최대 공약수를 선언

            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    if (num1[i] == num2[j]) // 두 배열에 공통으로 존재하는 약수 중
                    {
                        maxNum = Math.Max(num1[i], maxNum); // 가장 큰 수
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return maxNum;
        }
    }
}
