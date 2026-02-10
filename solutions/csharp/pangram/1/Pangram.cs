using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if(string.IsNullOrWhiteSpace(input)) return false;
        
        HashSet<char> alphabet = new HashSet<char>();
        string normalizedString = input.Trim().ToLower();
        
        foreach(char c in normalizedString)
        {
            if(!alphabet.Contains(c) && char.IsLetter(c))
            {
                char l = c;
                alphabet.Add(l);
            }
        }

        if(alphabet.Count == 26)
        {
            return true;
        }
        else{
            return false;
        }
    }
}
