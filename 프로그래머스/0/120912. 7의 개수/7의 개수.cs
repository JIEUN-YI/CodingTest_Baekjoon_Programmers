using System;

public class Solution {
    public int solution(int[] array) {
                    int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                while (num > 0)
                {

                    if (num % 10 == 7)
                    {
                        count++;
                        num /= 10;
                    }
                    else
                    {
                        num /= 10;
                    }
                }
            }
            return count;
    }
}