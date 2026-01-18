public class Solution {
    public int solution(int n) {
            int[] fibonacci = new int[n + 1];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int index = 2; index < n + 1; index++)
            {
                fibonacci[index] = (fibonacci[index - 1] + fibonacci[index - 2]) % 1234567;
            }

            return fibonacci[n];
    }
}