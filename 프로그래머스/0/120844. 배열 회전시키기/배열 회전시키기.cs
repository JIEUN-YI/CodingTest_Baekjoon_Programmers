using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
                               List<int> list = new List<int>();
            switch (direction)
            {
                case "right":
                    list.Add(numbers[numbers.Length - 1]);
                    for(int i = 0; i < numbers.Length - 1; i++) { list.Add(numbers[i]); }
                    break;
                case "left":
                    for (int i = 1; i < numbers.Length; i++) { list.Add(numbers[i]); }
                    list.Add(numbers[0]);
                    break;
                default:
                    break;

            }
            return list.ToArray();
    }
}