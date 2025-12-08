using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] emergency) {
            int[] order = new int[emergency.Length];
            for (int i = 0; i < emergency.Length; i++)
            {
                order[i] = emergency[i];
            }

            Array.Sort(order);
            Array.Reverse(order);

            int[] answer = new int[order.Length];
            for(int i = 0; i < order.Length; i++)
            {
                answer[i] = Array.IndexOf(order, emergency[i]) + 1;
            }
            return answer;
    }
}