using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
                    Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int item in array)
            {
                // key가 이미 Dictionary에 있다면
                if (dic.ContainsKey(item))
                {
                    // 갯수를 +1 하고 값에 저장
                    dic[item] += 1;
                }
                else
                {
                    // Dictionary에 없다면 새로 key를 저장하고 value를 1로 저장
                    dic.Add(item, 1);
                }
            }

            int maxNum = dic.Values.Max(); // 값의 최대값 찾기

            int count = 0;
            // Dictionary 값 중에서 최대값과 같은 값이 있는지를 확인하기
            foreach (int i in dic.Values)
            {
                if (i == maxNum) { count++; }
            }

            // 최빈값이 하나라면 그 값의 키를 반환
            if (count == 1) { return dic.SingleOrDefault(x => x.Value == maxNum).Key; }
            //if (count == 1) { return dic.FirstOrDefault(x => x.Value == maxNum).Key; }
            // 최빈값이 여러개면 -1 반환
            else { return -1; }
    }
}