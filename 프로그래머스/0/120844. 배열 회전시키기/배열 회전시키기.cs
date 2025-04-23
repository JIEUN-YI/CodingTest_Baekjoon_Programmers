using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
                   int[] answer = new int[] { };
            switch (direction)
            {
                case "right":
                    answer = new int[numbers.Length];
                    answer[0] = numbers[numbers.Length-1];
                    for(int i = 1; i < numbers.Length; i++)
                    {
                        answer[i] = numbers[i-1];
                    }
                    break;
                case "left":
                    answer = new int[numbers.Length];
                    answer[numbers.Length-1] = numbers[0];
                    for(int i = 1;i < numbers.Length; i++)
                    {
                        answer[i-1] = numbers[i];
                    }
                    break;
            }
            return answer;
    }
}