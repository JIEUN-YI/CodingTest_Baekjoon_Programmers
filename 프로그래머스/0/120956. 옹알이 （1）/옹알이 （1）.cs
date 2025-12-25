using System;

public class Solution {
    public int solution(string[] babbling) {
            string[] words = { "aya", "ye", "woo", "ma" };
            for(int i = 0; i < babbling.Length; i++)
            {
                foreach(string word in words)
                {
                    if (babbling[i].Contains(word))
                    {
                        babbling[i] = babbling[i].Replace(word, " ");
                    }
                }

            }
            for(int i =0;i<babbling.Length; i++)
            {
                babbling[i] = babbling[i].Replace(" ","");
            }
            int count = 0;
            foreach(string word in babbling)
            {
                if(word == "")
                {
                    count++;
                }
            }
            return count;
    }
}