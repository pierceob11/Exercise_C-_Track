public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        DateTime date = moment;
        date = date.AddSeconds(1000000000);
        return date;
    }
}