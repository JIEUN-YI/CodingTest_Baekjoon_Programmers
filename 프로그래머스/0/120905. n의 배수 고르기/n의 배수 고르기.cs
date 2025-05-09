using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist) {
                  List<int> list = new List<int>();
int j = 0;
for (int i = 0; i < numlist.Length; i++)
{
    if (numlist[i] % n == 0)
    {
        list.Add(numlist[i]);
    }
}
int[] answer = list.ToArray();
for (int i = 0; i < answer.Length; i++)
{
    Console.WriteLine(answer[i]);
}
return answer;
    }
}