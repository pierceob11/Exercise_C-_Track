using System.Collections.Generic;
using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if(string.IsNullOrEmpty(word) || string.IsNullOrWhiteSpace(word)) return true;

        string normalizedWord = word.ToLower();

        HashSet<char> letters = new HashSet<char>();

        foreach (char c in word)
        {
            if(char.IsLetter(c))
            {
                char lower = char.ToLower(c);
                
                if(letters.Contains(lower)){
                    return false;
                }
                else{
                    letters.Add(lower);
                }
            }
        }
        return true;
        }
    }
