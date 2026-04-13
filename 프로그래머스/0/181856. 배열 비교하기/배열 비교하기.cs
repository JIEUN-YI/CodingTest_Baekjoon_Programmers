using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
                    if (arr1.Length != arr2.Length)
            {
                if (arr1.Length > arr2.Length) { return 1; }
                else { return -1; }
            }
            else
            {
                int sum1 = 0;
                int sum2 = 0;
                foreach (int num in arr1) { sum1 += num; }
                foreach (int num in arr2) { sum2 += num; }
                if (sum1 > sum2) { return 1; }
                else if (sum1 < sum2) { return -1; }
                else { return 0; }
            }
    }
}