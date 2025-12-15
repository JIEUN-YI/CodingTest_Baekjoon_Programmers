using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] emergency) {
            Dictionary<int, int> ranking = new Dictionary<int, int>(emergency.Length);
            int[] values = new int[emergency.Length];
            for(int i = 0; i < values.Length; i++)
            {
                values[i] = emergency[i];
            }
            Array.Sort(values, (a, b) => b.CompareTo(a));
            // int[] values = emergency.OrderByDescending(x => x).ToArray();

            for (int rank = 0; rank < values.Length; rank++)
            {
                ranking.Add(values[rank], rank + 1);
            }

            int[] answer = new int[emergency.Length];
            int index = 0;
            foreach (int now in emergency)
            {
                answer[index] = ranking[now];
                index++;
            }


            return answer;
    }
}