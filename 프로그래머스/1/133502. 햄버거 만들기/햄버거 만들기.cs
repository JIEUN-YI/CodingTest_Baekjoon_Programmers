using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
            List<int> makingBurgers = new List<int>(ingredient.Length);
            int answer = 0;
            int count = 0;
            for (int i = 0; i < ingredient.Length; i++)
            {
                makingBurgers.Add(ingredient[i]);
                count++;
                if (count > 3)
                {
                    if (makingBurgers[count - 1] == 1
                        && makingBurgers[count - 2] == 3
                        && makingBurgers[count - 3] == 2
                        && makingBurgers[count - 4] == 1)
                    {
                        makingBurgers.RemoveRange(count - 4, 4);
                        answer++;
                        count -= 4;
                    }
                }
            }
            return answer;
    }
}