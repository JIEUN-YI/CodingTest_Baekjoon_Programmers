using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
                    int count = 0;
            foreach (string key in dic)
            {
                if (key.Length == spell.Length)
                {
                    for (int i = 0; i < spell.Length; i++)
                    {
                        for (int j = 0; j < key.Length; j++)
                        {
                            if (spell[i] == key[j].ToString())
                            {
                                count++;
                                break;
                            }
                            else
                            {
                                continue;
                            }

                        }
                    }
                    if (count == spell.Length)
                    {
                        return 1;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
                return 2; 
    }
}