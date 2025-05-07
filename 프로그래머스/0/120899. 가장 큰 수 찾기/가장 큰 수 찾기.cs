using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] findNum = new int[2];
for(int i = 1; i < array.Length; i++)
{
    if(array[i-1] > array[i])
    {
        findNum[0] = array[i-1];
        findNum[1] = i-1;
    }
    else if(array[i-1] <= array[i])
    {
        findNum[0] = array[i];
        findNum[1] = i;
    }
}
return findNum;
    }
}