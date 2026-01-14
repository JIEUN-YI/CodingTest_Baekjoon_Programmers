namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string input = sr.ReadLine();
            // 찾을 값의 인덱스
            int xIndex = 0;
            // 모든 ISBN의 합
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (int.TryParse(input[i].ToString(), out int num) == false)
                {
                    xIndex = i;
                }
                else
                {
                    // ISBN 자릿수가 짝수인 경우 *1, 홀수인 경우 *3
                    if (i % 2 != 0) { sum += 3 * num; }
                    else { sum += num; }
                }
            }
            // 모든 수의 합이 10의 배수라면
            if (sum % 10 == 0) { Console.WriteLine(0); }
            else
            {
                int find = sum % 10;
                find = 10 - find;
                if (xIndex % 2 == 0) { Console.WriteLine(find); }
                else
                {
                    while (find % 3 != 0)
                    {
                        find += 10;
                    }
                    Console.WriteLine(find/3);
                }
            }
        }

    }
}
