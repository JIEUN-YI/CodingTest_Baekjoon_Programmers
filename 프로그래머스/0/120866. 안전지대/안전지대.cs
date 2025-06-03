using System;

public class Solution {
    public int solution(int[,] board) {
            bool[,] safeArea = new bool[board.GetLength(0), board.GetLength(1)];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++) // 주어진 2차원 배열을 돌면서
                {
                    if (board[i, j] == 1) // 지뢰가 있는 1을 찾은 경우
                    {
                        // 주변 9칸을 true로 safeArea 배열을 변경함
                        // 범위 설정이 중요
                        // 각 행열은 0부터 시작해야하며 -1값이 0보다 작은 경우 시작값은 0이고, 배열의 사이즈를 넘어가지 않고, +1값까지 변동
                        for (int row = Math.Max(0,i - 1); row < safeArea.GetLength(0) && row <= i + 1; row++)
                        {
                            for (int col = Math.Max(0,j - 1); col < safeArea.GetLength(1) && col <= j + 1; col++)
                            {
                                safeArea[row, col] = true;
                            }
                        }
                    }
                }
            }
            int count = 0;
            foreach(bool i in safeArea)
            {
                if(i == false)
                {
                    count++;
                }
            }
            return count;
    }
}