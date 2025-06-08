using System.Text;

namespace ConsoleStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            string input = sr.ReadLine();

            while (input[0] != '.')
            {
                Stack<char> stack = new Stack<char>();

                foreach (char i in input) // 한글자씩 확인하며
                {
                    if (i == '(' || i == '[') // 여는 괄호인 경우
                    {
                        stack.Push(i); // 삽입
                    }
                    else // 닫는 괄호인 경우
                    {
                        if (stack.Count > 0)
                        {
                            if (i == ')')
                            {
                                if (stack.Peek() == '(')
                                {
                                    stack.Pop();
                                }
                                else
                                {
                                    sb.Append("no");
                                    break;
                                }
                            }
                            else if (i == ']')
                            {
                                if (stack.Peek() == '[')
                                {
                                    stack.Pop();
                                }
                                else
                                {
                                    sb.Append("no");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (i == ')' || i == ']')
                            {
                                sb.Append("no");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }

                if (sb.Length == 0)
                {
                    if (stack.Count == 0)
                    {
                        sb.Append("yes");
                    }
                    else
                    {
                        sb.Append("no");
                    }
                }

                Console.WriteLine(sb.ToString());

                sb.Clear();
                input = sr.ReadLine();
            }
        }
    }
}

