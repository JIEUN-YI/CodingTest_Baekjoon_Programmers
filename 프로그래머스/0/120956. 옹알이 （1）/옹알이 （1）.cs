using System;

public class Solution {
    public int solution(string[] babbling) {
            string[] words = { "aya", "ye", "woo", "ma" };
            for (int i = 0; i < babbling.Length; i++)
            {
                foreach (string word in words)
                {
                    babbling[i] = babbling[i].Replace(word, " ");
                }
                babbling[i] = babbling[i].Replace(" ", "");

            }

            int count = 0;
            foreach (string word in babbling)
            {
                if (word == "")
                {
                    count++;
                }
            }
            return count;
    }
}