using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
                    // 키 = array의 값, 값 = 같은 수 의 개수
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int item in array)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item] += 1;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }

            int maxNum = dic.Values.Max(); // 값의 최대값 찾기

            int count = 0;
            foreach (int i in dic.Values)
            {
                if(i == maxNum) { count++; }
            }

            if (count == 1) { return dic.FirstOrDefault(x => x.Value == maxNum).Key; }
            else { return -1; }
    }
}