using System;
using System.Linq;

public class Solution {
    public int solution(int[] array, int n) {
                                    int answer = 0;
            Array.Sort(array);
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (n - array[i] < 0)
                {
                    result[i] = array[i] - n;
                }
                else
                {
                    result[i] = n - array[i];
                }
            }
            int j = result.Min();

            for (int i = 0; i < result.Length; i++)
            {
                if (j == result[i])
                {
                    answer = array[i];
                    return answer;
                }
            }
            return answer;
        }
    }
