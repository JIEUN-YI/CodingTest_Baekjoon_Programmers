using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] ingredient) {
            int[] recipe = { 1, 3, 2, 1 };
            int count = 0;
            Stack<int> stack = new Stack<int>();
            foreach (int i in ingredient)
            {
                stack.Push(i);
                if (stack.Count >= 4)
                {
                    bool isHambuger = true;
                    for (int ing = 0; ing < 4; ing++)
                    {
                        if (recipe[ing] != stack.ElementAt(ing))
                        {
                            isHambuger = false;
                            break;
                        }
                    }
                    if (isHambuger)
                    {
                        for (int index = 0; index < 4; index++)
                        {
                            stack.Pop();
                        }
                        count++;
                    }
                }
            }
            return count;
    }
}