using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int count);
            while(count > 0)
            {
                string input = Console.ReadLine();
                Stack<char> stack = new Stack<char>(input.Length);
                for(int i = 0; i < input.Length; i++)
                {
                    if (stack.Count > 0)
                    {
                        if(stack.Peek() != input[i])
                        {
                            stack.Pop();
                            continue;
                        }
                        else
                        {
                            stack.Push(input[i]);
                            continue;
                        }
                    }
                    else if (stack.Count == 0)
                    {
                        if (input[i] == ')')
                        {
                            stack.Push(input[i]);
                            break;
                        }
                        else
                        {
                            stack.Push(input[i]);
                            continue;
                        }
                    }
                }

                if(stack.Count == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                count--;
            }
        }
    }
}