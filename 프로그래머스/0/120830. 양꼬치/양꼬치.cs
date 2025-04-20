using System;

public class Solution {
    public int solution(int n, int k) {
                    k -= n / 10; // 구매한 음료수
            return 12000 * n + 2000 * k;
    }
}