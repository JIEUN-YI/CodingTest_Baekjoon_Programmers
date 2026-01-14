namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = new string[3];
            for(int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            // 입력 값 중 숫자
            int find = 0;
            // 수열의 시작
            int start = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(int.TryParse(input[i], out find))
                {
                    start = find - i;
                    break;
                }
            }
            // 수열의 끝
            int end = start + 3;
            // 조건에 따른 출력
            if (end % 3 == 0 && end % 5 != 0) { Console.WriteLine("Fizz"); }
            else if (end % 3 != 0 && end % 5 == 0) { Console.WriteLine("Buzz"); }
            else if (end % 3 == 0 && end % 5 == 0) { Console.WriteLine("FizzBuzz"); }
            else { Console.WriteLine(end); }
        }

    }
}
