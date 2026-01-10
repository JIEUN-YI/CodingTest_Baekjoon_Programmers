using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int.TryParse(sr.ReadLine(), out int L);
            string input = sr.ReadLine();
            Dictionary<char,int> map = new Dictionary<char,int>();
            map.Add('a', 1); map.Add('b', 2); map.Add('c', 3); map.Add('d', 4); map.Add('e', 5); map.Add('f', 6); map.Add('g', 7); map.Add('h', 8); map.Add('i', 9);
            map.Add('j', 10); map.Add('k', 11); map.Add('l', 12); map.Add('m', 13); map.Add('n', 14); map.Add('o', 15); map.Add('p', 16); map.Add('q', 17); map.Add('r', 18); map.Add('s', 19); map.Add('t', 20);
            map.Add('u', 21); map.Add('v', 22); map.Add('w', 23); map.Add('x', 24); map.Add('y', 25); map.Add('z', 26);

            int[] finding = new int[L];
            // 사용할 수열 설정
            for(int index =0; index < L; index++)
            {
                finding[index] = map[input[index]];
            }

            int sum = 0;
            for(int index = 0; index < L; index++)
            {
                int findNum = 1;
                int count = index;
                while(count > 0)
                {
                    findNum *= 31;
                    count--;
                }
                sum += findNum * finding[index];
            }

            Console.WriteLine(sum);
        }
    }
}
