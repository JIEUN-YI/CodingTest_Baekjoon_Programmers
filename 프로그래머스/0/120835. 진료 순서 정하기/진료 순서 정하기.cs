using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Solution {
    public int[] solution(int[] emergency) {
                    int[] result = new int[emergency.Length];
            Dictionary<int,int> map = new Dictionary<int,int>();

            for(int i = 0; i < emergency.Length; i++)
            {
                map.Add(i, emergency[i]);
            }

            map = map.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int count = 1;
            foreach (int i in map.Keys)
            {
                result[i] = count;
                count++;
            }

            return result;
    }
}