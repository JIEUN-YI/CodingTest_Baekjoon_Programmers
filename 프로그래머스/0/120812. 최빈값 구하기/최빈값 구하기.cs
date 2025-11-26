using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
            int[] find = new int[array.Max() + 1];

            foreach(int i in array)
            {
                find[i] += 1;
            }

            int maxCount = find.Max();
            int count = 0;
            foreach(int num in find)
            {
                if(num == maxCount)
                {
                    count++;
                }
            }
            
            if(count == 1) { return Array.IndexOf(find, maxCount); }
            else { return -1; }
    }
}