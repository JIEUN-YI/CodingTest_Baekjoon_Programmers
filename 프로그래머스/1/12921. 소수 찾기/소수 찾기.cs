public class Solution {
    public int solution(int n) {
            // 소수 이면 false
            bool[] primeNums = new bool[n + 1];
            primeNums[0] = true;
            primeNums[1] = true;

            // for (int index = 2; index < Math.Sqrt(primeNums.Length); index++)
            for (int index = 2; index < index * index; index++)
            {
                // index의 제곱수 이전의 수는 이미 다른 수에 의해서 지워짐. 따라서 그 이상부터 검토
                //  += index를 통해 index의 배수만 찾기
                for (long i = index * index; i < primeNums.Length; i += index)
                {
                    // 나눠지는 경우 소수가 아님
                    primeNums[i] = true;
                }
            }

            int count = 0;
            foreach (bool a in primeNums)
            {
                if (!a) count++;
            }

            return count;
    }
}