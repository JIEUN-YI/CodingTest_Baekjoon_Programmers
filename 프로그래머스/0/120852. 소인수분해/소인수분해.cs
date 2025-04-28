using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n) {
        List<int> answer = new List<int>();
while (n > 1)
{
    for (int i = 2; i <= n; i++)
    {
        if (n % i == 0)
        {
            if (!answer.Contains(i))
            {
                n /= i;
                answer.Add(i);
                break;
            }
            else
            {
                n /= i;
                break;
            }
        }
        else
        {
            continue;
        }
    }
}
int[] result = answer.ToArray();
return result;
    }
}