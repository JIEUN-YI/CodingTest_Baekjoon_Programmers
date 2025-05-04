namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            bool[,] inputChess = new bool[int.Parse(input[0]), int.Parse(input[1])]; // 주어진 크기의 체스판

            // 입력한 체스판의 모양 - 변경이 쉽게 B true로 변경하여 저장
            for (int i = 0; i < inputChess.GetLength(0); i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < inputChess.GetLength(1); j++)
                {
                    if (line[j] == 'B')
                    {
                        inputChess[i, j] = true;
                    }
                    else
                    {
                        inputChess[i, j] = false;
                    }
                }
            }
            bool[,] chess = new bool[8, 8]; // 사용할 8x8 체스판

            int changeCount = 64; // 8X8 체스판에서 전부 다시 입력하는 변경 횟수

            for (int i = 0; i < inputChess.GetLength(0); i++)
            {
                for (int j = 0; j < inputChess.GetLength(1); j++)
                {
                    // 범위가 맞는 경우 chess를 제작
                    if (i + 7 < inputChess.GetLength(0) && j + 7 < inputChess.GetLength(1))
                    {
                        for (int line = 0, n = i; line < chess.GetLength(0); line++, n++)
                        {
                            for (int row = 0, k = j; row < chess.GetLength(1); row++, k++)
                            {
                                chess[line, row] = inputChess[n, k];
                            }
                        }
                    }
                    // inputChess의 전 구역 안에서
                    // 가로 세로 길이가 8인 배열을 선택
                    // 세로 시작점을 다르게 맞추고
                    // 가로 범위를 제작

                    bool[,] B_result = (bool[,])chess.Clone();
                    int count = 0; // 변경하는 횟수

                    if (B_result[0, 0] != true)
                    {
                        B_result[0, 0] = true;
                        count++;
                    }
                    // 각 줄의 맨 앞이 지그재그로 만들어지도록 변경
                    for (int line = 0; line < B_result.GetLength(0) - 1; line++)
                    {
                        if (B_result[line, 0] == B_result[line + 1, 0]) // 두 값이 같으면
                        {
                            B_result[line + 1, 0] = !B_result[line + 1, 0]; // 변경
                            count++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    // 모든 chess를 돌면서 앞의 항목과 다르게 변경
                    for (int line = 0; line < B_result.GetLength(0); line++)
                    {
                        for (int row = 0; row < B_result.GetLength(1) - 1; row++)
                        {
                            if (B_result[line, row] == B_result[line, row + 1])
                            {
                                B_result[line, row + 1] = !B_result[line, row + 1];
                                count++;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    // 확인한 count와 changeCount를 비교하여 작은 수를 저장
                    changeCount = Math.Min(changeCount, count);


                    bool[,] W_result = (bool[,])chess.Clone();
                    count = 0;

                    if (W_result[0, 0] != false)
                    {
                        W_result[0, 0] = false;
                        count++;
                    }
                    // 각 줄의 맨 앞이 지그재그로 만들어지도록 변경
                    for (int line = 0; line < W_result.GetLength(0) - 1; line++)
                    {
                        if (W_result[line, 0] == W_result[line + 1, 0]) // 두 값이 같으면
                        {
                            W_result[line + 1, 0] = !W_result[line + 1, 0]; // 변경
                            count++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    // 모든 chess를 돌면서 앞의 항목과 다르게 변경
                    for (int line = 0; line < W_result.GetLength(0); line++)
                    {
                        for (int row = 0; row < W_result.GetLength(1) - 1; row++)
                        {
                            if (W_result[line, row] == W_result[line, row + 1])
                            {
                                W_result[line, row + 1] = !W_result[line, row + 1];
                                count++;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    // 확인한 count와 changeCount를 비교하여 작은 수를 저장
                    changeCount = Math.Min(changeCount, count);
                }
            }
            Console.WriteLine(changeCount);
        }
    }
}
