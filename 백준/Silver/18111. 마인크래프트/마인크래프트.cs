using System.Diagnostics;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string[] input = sr.ReadLine().Split(" ");
            int[,] ground = new int[int.Parse(input[0]), int.Parse(input[1])];
            int.TryParse(input[2], out int invent);

            // 가장 적은 시간 찾기
            int minTime = 100000000;
            // 가장 적은 시간일때의 높이
            int resultHight = 0;
            // 땅 만들기
            for (int y = 0; y < ground.GetLength(0); y++)
            {
                string[] inputG = sr.ReadLine().Split(" ");
                for (int x = 0; x < ground.GetLength(1); x++)
                {
                    ground[y, x] = int.Parse(inputG[x]);
                }
            }

            // 예외 1 * 1의 땅일때
            if (ground.GetLength(0) == 1 && ground.GetLength(1) == 1)
            {
                minTime = 0;
                resultHight = ground[0, 0];
            }
            else
            {
                // 가장 높은 땅의 높이와 낮은 높이
                int hight = 0;
                int low = 256;
                for (int y = 0; y < ground.GetLength(0); y++)
                {
                    for (int x = 0; x < ground.GetLength(1); x++)
                    {
                        hight = Math.Max(hight, ground[y, x]);
                        low = Math.Min(low, ground[y, x]);
                    }
                }

                // 가장 높은 높이부터 땅 고르기 시작
                while (hight >= low)
                {
                    int time = 0;
                    int useB = invent;
                    for (int y = 0; y < ground.GetLength(0); y++)
                    {
                        for (int x = 0; x < ground.GetLength(1); x++)
                        {
                            // 높이를 만들기 위해 필요한 블럭의 갯수 
                            int count = hight - ground[y, x];
                            if (count > 0) // + : 인벤토리에서 빼와서 쌓기
                            {
                                useB -= count;
                                time += 1 * count; // 각 블럭 당 2초
                            }
                            else if (count < 0)// - : 제거하여 인벤토리에 넣기
                            {
                                int abs = Math.Abs(count);
                                useB += abs;
                                time += 2 * abs; // 각 블럭 당 1초
                            }
                            else
                            {
                                continue;
                            }
                        }

                    }
                    if (useB >= 0)// useB가 음수이면 작업 불가능
                    {
                        if (minTime > time) // 현재값이 최소값인 경우
                        {
                            // 최소 시간과 높이 갱신
                            minTime = time;
                            resultHight = hight;
                        }
                    }
                    hight--;
                }
            }

            Console.WriteLine(minTime + " " + resultHight);
        }
    }

}