using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int N);
            bool isCheck = true; // 제작 가능 여부 확인
            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();

            // 수열을 만들기 위해 주어지는 수
            int[] find = new int[N];
            for (int i = 0; i < N; i++)
            {
                int.TryParse(sr.ReadLine(), out find[i]);
            }

            // 1부터 N까지 입력할 수
            int count = 1;

            // 주어진 수를 돌면서
            foreach (int num in find)
            {
                // 반복
                while (count <= N + 1)
                {
                    // 주어진 수가 입력하는 수보다 크거나 같을 때
                    if (num >= count)
                    {
                        stack.Push(count);
                        sb.AppendLine("+");
                        count++;
                        continue;
                    }
                    else
                    {
                        // 스택 용량 파악
                        if (stack.Count != 0)
                        {
                            // 두 수가 같으면 => 종료
                            if (stack.Peek() == num)
                            {
                                stack.Pop();
                                sb.AppendLine("-");
                                break;
                            }
                            // 스택 값이 크면 => 그대로 반복
                            else if (stack.Peek() > num)
                            {
                                stack.Pop();
                                sb.AppendLine("-");
                                continue;
                            }
                            // 그 외 => 수열 제작 불가 => 종료
                            else
                            {
                                isCheck = false;
                                break;
                            }
                        }
                        else // 용량이 없다면 제작 불가
                        {
                            isCheck = false;
                            break;
                        }
                    }
                }
                if (!isCheck) { sb.Clear(); sb.AppendLine("NO"); break; }
            }
            Console.WriteLine(sb.ToString());
        }
    }

}
