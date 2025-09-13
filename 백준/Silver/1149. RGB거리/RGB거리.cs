namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            int.TryParse(sr.ReadLine(), out int house);
            int[,] colorings = new int[house, 3];
            int count = 0;
            #region 사용하는 colorings 배열을 입력받아 제작
            while (count < house) 
            {
                string[] input = sr.ReadLine().Split(" ");
                for (int i = 0; i < input.Length; i++)
                {
                    int cost = 0;
                    switch (i)
                    {
                        case 0:
                            int.TryParse(input[i], out cost);
                            colorings[count, i] = cost;
                            break;
                        case 1:
                            int.TryParse(input[i], out cost);
                            colorings[count, i] = cost;
                            break;
                        case 2:
                            int.TryParse(input[i], out cost);
                            colorings[count, i] = cost;
                            break;
                    }
                }
                count++;
            }
            #endregion

            for(int y = 1; y < house; y++) // 2번째 열부터 비용을 저장
            {
                colorings[y, 0] = colorings[y, 0] + Math.Min(colorings[y - 1, 1], colorings[y - 1, 2]);
                colorings[y, 1] = colorings[y, 1] + Math.Min(colorings[y - 1, 0], colorings[y - 1, 2]);
                colorings[y, 2] = colorings[y, 2] + Math.Min(colorings[y - 1, 0], colorings[y - 1, 1]);
            }

            int minCost = 100000001;
            for(int x = 0; x < 3; x++) // 마지막 열의 모든 행의 비용 계산
            {
                minCost = Math.Min(colorings[house - 1, x], minCost);
            }

            Console.WriteLine(minCost);
        }
    }



}