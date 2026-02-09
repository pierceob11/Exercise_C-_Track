using System;
using System.Collections.Generic;

public static class Languages
{
    
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        List<string> existingList = new List<string>();

        existingList.Add("C#");
        existingList.Add("Clojure");
        existingList.Add("Elm");

        return existingList;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        var existingList = languages;

        existingList.Add(language);

        return existingList;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        foreach(string languageInList in languages){
            if(language == languageInList){
                return true;
            }
        }
        return false;
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if(languages.Count == 0)
            return false;
        
        if(languages[0] == "C#" )
            return true;

        if((languages.Count == 2 || languages.Count == 3) && languages[1] == "C#")
            return true;
        
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        var seen = new HashSet<string>();
        foreach(var l in languages){
            if(!seen.Add(l)) return false;
        }
        return true;
    }
}
