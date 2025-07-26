using Microsoft.VisualBasic;

namespace ConsoleStudy
{

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int num); // 한 변의 크기
            Paper paper = new Paper(num);
            int count = 0; // 0부터 시작
            while (count < num)
            {
                string[] input = sr.ReadLine().Split(" ");
                for (int x = 0; x < input.Length; x++)
                {
                    paper.inputPaper(count, x, int.Parse(input[x]));
                }
                count++;
            }

            paper.Find(paper.paper);

            Console.WriteLine(paper.wCount);
            Console.WriteLine(paper.bCount);
        }

    }
    public class Paper
    {
        public int num;
        public int[,] paper;

        public int wCount = 0; // 흰색 종이
        public int bCount = 0; // 파란 종이

        public Paper(int num)
        {
            this.num = num;
            paper = new int[num, num];
        }

        // 값을 넣는 함수
        public void inputPaper(int y, int x, int value)
        {
            this.paper[y, x] = value;
        }

        // 분할한 새 배열을 제작
        public int[,] MakeNewPaper(int[,] nowPaper, int[,] sample, int lineStart, int rowStart, int count)
        {
            for (int line = lineStart, nowLine = 0; line < lineStart + count; line++, nowLine++)
            {
                int k = rowStart + count;
                for (int row = rowStart, nowRow = 0; row < rowStart + count; row++, nowRow++)
                {
                    nowPaper[nowLine, nowRow] = sample[line, row];
                }
            }
            return nowPaper;
        }

        // 잘라야하는 지 확인
        public bool CheckCut(int[,] nowPaper, int startY, int startX)
        {
            bool isCut = false; // true = 자르기
            // 배열의 전체 탐색
            for (int y = 0; y < nowPaper.GetLength(0); y++)
            {
                for (int x = 0; x < nowPaper.GetLength(1); x++)
                {
                    if (nowPaper[startY, startX] == nowPaper[y, x])
                    {
                        continue;
                    }
                    else
                    {
                        isCut = true;
                        return isCut;
                    }
                }
            }
            return isCut;
        }

        public void PaperColor(int[,] nowPaper)
        {
            if (nowPaper[0, 0] == 0)
            {
                wCount++;
            }
            else
            {
                bCount++;
            }
        }

        /// <summary>
        ///  배열을 받아서 탐색
        ///  1. 배열을 전체 탐색을 돌면서 다른 값이 나오면 탐색을 종료
        ///     - 종료한 시점에서 n/2개로 새로운 배열 제작 후 Find() 재귀로 실행
        ///  2. 배열을 전체 탐색을 돌면서 모두 같은 값이 나오는 경우
        ///     - 배열의 값에 따라 파란색인지 흰색인지 판단
        /// </summary>
        /// <param name="n"></param>
        /// <param name="sample"></param>
        public void Find(int[,] sample)
        {
            // 현재 종이를 잘라야하는 지 판정
            bool isCut = CheckCut(sample, 0, 0);
            if (isCut)
            {
                int count = sample.GetLength(0) / 2;
                // 4분할 배열 제작 후 Find()
                int[,] first = new int[count, count];
                first = MakeNewPaper(first, sample, 0, 0, count);
                if (CheckCut(first, 0, 0))
                {
                    Find(first);
                }
                else
                {
                    PaperColor(first);
                }

                int[,] sceond = new int[count, count];
                sceond = MakeNewPaper(sceond, sample, 0, count, count);
                if (CheckCut(sceond, 0, 0))
                {
                    Find(sceond);
                }
                else
                {
                    PaperColor(sceond);
                }

                int[,] third = new int[count, count];
                third = MakeNewPaper(third, sample, count, 0, count);
                if (CheckCut(third, 0, 0))
                {
                    Find(third);
                }
                else
                {
                    PaperColor(third);
                }

                int[,] fourth = new int[count, count];
                fourth = MakeNewPaper(fourth, sample, count, count, count);
                if (CheckCut(fourth, 0, 0))
                {
                    Find(fourth);
                }
                else
                {
                    PaperColor(fourth);
                }
            }
            else
            {
                PaperColor(sample);
            }
        }
    }
}