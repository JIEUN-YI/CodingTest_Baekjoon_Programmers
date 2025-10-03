using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
                    // 검색을 위한 사전 제작
            Dictionary<string, int> ranking = new Dictionary<string, int>(players.Length);
            for(int index = 0; index < players.Length; index++)
            {
                ranking[players[index]] = index;
            }

            foreach(string player in callings)
            {
                if (ranking.ContainsKey(player))
                {
                    int rank = ranking[player]; // 현재 랭킹
                    string name = players[rank - 1]; // 올라갈 위치에 있는 플레이어

                    // 추월
                    // 사전 수정
                    ranking[player] = rank - 1;
                    ranking[name] = rank;
                    // 원본 수정
                    players[rank - 1] = player;
                    players[rank] = name;
                    
                }
            }

            return players;
        }
    }