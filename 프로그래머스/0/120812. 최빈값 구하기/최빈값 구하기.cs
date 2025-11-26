using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array) {
                    Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                int countNum = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (!dic.ContainsKey(array[i])) // 탐색해서 저장하지 않은 값만
                    {
                        if (array[i] == array[j])
                        {
                            countNum++;
                        }
                        else continue;
                    }
                    else break;
                }
                if(!dic.ContainsKey(array[i]))
                {
                    dic.Add(array[i], countNum);
                }
            }
            int maxNum = 0;
            int key = 0;
            int count = 0;
            foreach(int i in dic.Values)
            {
                maxNum = Math.Max(maxNum, i);
            }
            foreach(int i in dic.Keys)
            {
                dic.TryGetValue(i, out int value);
                if ( value == maxNum)
                {
                    key = i;
                    count++;
                }
            }
            if(count > 1)
            {
                return -1;
            }
            return key;
    }
}