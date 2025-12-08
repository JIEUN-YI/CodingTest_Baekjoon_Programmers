using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] emergency) {
            int[] order = emergency.OrderByDescending(x => x).ToArray();

            return emergency.Select(x=>Array.IndexOf(order,x)+1).ToArray();
    }
}