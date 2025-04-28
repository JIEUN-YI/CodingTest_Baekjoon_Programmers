namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N); // 참가자 수 N
            string[] T_shirt = Console.ReadLine().Split(" "); // 사이즈 별 개수
            int[] shirtCount = new int[T_shirt.Length]; // int 배열로 변경하여 저장
            for(int i = 0; i < shirtCount.Length; i++)
            {
                int.TryParse(T_shirt[i], out int num);
                shirtCount[i] = num;
            }
            string[] count = Console.ReadLine().Split(" ");
            int.TryParse(count[0], out int T); // 티셔츠 묶음의 개수
            int.TryParse(count[1], out int P); // 펜 묶음의 개수

            int T_sum = 0; // 모든 티셔츠 묶음의 합
            
            // 모든 티셔츠의 합을 구하기
            foreach(int i in shirtCount)
            {
                if (i % T != 0) // 나머지가 0이 아닌 경우
                {
                    T_sum += i / T + 1; // 몫 + 1 세트 구매
                }
                else // 나머지가 0인 경우
                {
                    T_sum += i / T; // 몫 세트 구매
                }
            }
            
            Console.WriteLine(T_sum); // 최소 주문 묶음 출력
            Console.WriteLine(N / P + " " + N % P); // 최소 묶음과 나머지 개수

        }
    }
}