using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] priorities, int location) {
                    // queue를 선언
            Queue<Items> queue = new Queue<Items>();
            int index = 0; // 함께 저장할 인덱스 값
            foreach(int pri  in priorities) // 원하는 Items에 맞춰서 queue 생성
            {
                Items item = new Items();
                item.index = index;
                item.prio = pri;
                index++;
                queue.Enqueue(item);
            }
            int[] result = new int[priorities.Length]; // 출력 결과를 인덱스를 저장할 배열
            int count = 0; // 저장할 배열의 인덱스 값
            while(queue.Count > 0) // 큐의 용량이 있는 동안
            {
                Items[] find = queue.ToArray(); // Items 배열로 queue를 변환
                Items item = queue.Dequeue(); // 맨 앞의 값 가져오기

                int max = find.Max(i => i.prio); // 최대값을 찾아서
                if(item.prio == max) // 우선순위 최대값과 맨 앞에 값의 우선순위가 같으면
                {
                    result[count] = item.index; // 인덱스 값 저장
                    count++; // 배열의 인덱스 상승
                }
                else // 아니면
                {
                    queue.Enqueue(item); // 큐에 삽임
                }
            }
            for(int i = 0; i < result.Length; i++) // 완성된 배열을 확인하여
            {
                if (result[i] == location) // 값이 location과 같으면
                {
                    return i + 1;
                    Console.WriteLine($"{i + 1}");
                    break;
                }
            }
            return 0;
    }
    public class Items
{
    public int prio;
    public int index;
}
}