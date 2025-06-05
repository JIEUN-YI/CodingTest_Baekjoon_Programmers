namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int count);
            
            Stack<int> stack = new Stack<int>();
            while (count > 0)
            {
                int.TryParse(sr.ReadLine(), out int num); // 저장할 숫자
                if (num == 0) // 0 입력 시
                {
                    stack.Pop(); // 가장 최근 입력 삭제
                    count--;
                    continue;
                }
                else
                {
                    stack.Push(num);
                    count--;
                    continue;
                }
            }

            int sum = 0;
            foreach(int i in stack) // 스택의 모든 수의 합
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}

