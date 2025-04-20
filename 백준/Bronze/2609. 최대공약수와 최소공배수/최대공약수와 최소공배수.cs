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
            numbers.Add(1);
            numbers.Add(num);


            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    if (!numbers.Contains(i))
                    {
                        numbers.Add(i);
                        numbers.Add(num / i);
                        continue;
                    }
                }
            }

            int[] result = numbers.ToArray();
            Array.Sort(result);
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
            int maxNum = 0;

            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    if (num1[i] == num2[j])
                    {
                        maxNum = Math.Max(num1[i], maxNum);
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