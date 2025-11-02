using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int.TryParse(sr.ReadLine(), out int test); // 테스트 케이스의 수
            while (test > 0)
            { 

                int.TryParse(sr.ReadLine(), out int note1Count);
                string[] note1Input = sr.ReadLine().Split(" ");
                int[] note1 = new int[note1Count];

                // 수첩 1 제작 = 하루 동안 본 정수
                for (int i = 0; i < note1Input.Length; i++)
                {
                    int.TryParse(note1Input[i], out note1[i]);
                }
                Array.Sort(note1);

                int.TryParse(sr.ReadLine(), out int note2Count);
                string[] note2Input = sr.ReadLine().Split(" ");
                int[] note2 = new int[note2Count];

                // 수첩 2 제작 = 봤다고 주장하는 정수
                for (int i = 0; i < note2Input.Length; i++)
                {
                    int.TryParse(note2Input[i], out note2[i]);
                }

                // 이진 탐색
                foreach (int num in note2)
                {
                    int high = note1.Length - 1;
                    int low = 0;
                    int mid = (high + low) / 2;
                    bool isCheck = false;
                    while (low <= high)
                    {     
                        if (num == note1[mid])
                        {
                            isCheck = true;
                            break;
                        }
                        else if (num > note1[mid])
                        {
                            low = mid + 1;
                            mid = (high + low) / 2;
                        }
                        else
                        {
                            high = mid - 1;
                            mid = (low + high) / 2;
                        }
                    }
                    if (isCheck) { sb.AppendLine("1"); }
                    else { sb.AppendLine("0"); }
                }
                test--;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}