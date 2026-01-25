using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights) {
            // 다리에 진입한 트럭
            Queue<int> bridgeQueue = new Queue<int>();
            int nowBridgeW = 0; // 현재 다리에 있는 트럭 무게
            int time = 0; // 총 시간

            // 대기 트럭을 추가하기
            for (int index = 0; index < truck_weights.Length; index++)
            {
                while (true)
                {
                    // 다리가 꽉 찬 경우, 트럭 제외
                    if (bridgeQueue.Count == bridge_length)
                    {
                        nowBridgeW -= bridgeQueue.Dequeue(); // 다리 건너감
                    }
                    // 다리에 다른 트럭 진입 가능
                    if (nowBridgeW + truck_weights[index] <= weight)
                    {
                        bridgeQueue.Enqueue(truck_weights[index]); // 트럭 추가
                        nowBridgeW += truck_weights[index];
                        time++; //시간 증가
                        break; // 해당 트럭이 추가되었으니 반복 종료
                    }
                    // 다른 트럭 진입 불가
                    else
                    {
                        bridgeQueue.Enqueue(0); // 빈 트럭 위치 만들기
                        time++;
                        continue; // 해당 트럭이 추가되지 못했으니 반복
                    }
                }
            }
            // 모든 트럭이 올라갔으면, 마지막 트럭이 빠져나오는 기준 시간 = 다리의 길이
            time += bridge_length;
            return time;
    }
}