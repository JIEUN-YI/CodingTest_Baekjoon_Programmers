using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int num) {
                    List<int> list = new List<int>();
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (!list.Contains(i))
                    {
                        list.Add(i);
                    }
                    if (!list.Contains(num / i))
                    {
                        list.Add(num / i);
                    }
                }
                else if (num % i != 0)
                {
                    continue;
                }
            }
            int[] result = list.ToArray();
            Array.Sort(result);
            return result;
    }
}