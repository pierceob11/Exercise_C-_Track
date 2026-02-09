using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf(": ");

        string message = logLine.Substring(index + 1).Trim();

        return message;
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.IndexOf("[");
        int endIndex = logLine.IndexOf("]");

        string message = logLine.Substring(startIndex + 1, endIndex - 1).ToLower();
        return message;
    }

    public static string Reformat(string logLine)
    {
        return  $"{LogLine.Message(logLine)} ({LogLevel(logLine)})";
    }
}
