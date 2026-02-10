using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        // Get the index
        int start = str.IndexOf(delimiter);
        int after = start + delimiter.Length;
        
        string subString = str.Substring(after);

        return subString;
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter)
    {
        int startLeftIndex = str.IndexOf(startDelimiter);
        int afterLeftIndex = startLeftIndex + startDelimiter.Length;
        
        int startRightIndex = str.IndexOf(endDelimiter);
        int afterRightIndex = startRightIndex + endDelimiter.Length;

        string subString = str.Substring(afterLeftIndex, startRightIndex - afterLeftIndex);

        return subString;
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
       return SubstringAfter(str, ": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return SubstringBetween(str, "[", "]");
    }
}