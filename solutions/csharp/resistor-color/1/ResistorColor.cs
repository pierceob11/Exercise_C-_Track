public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        var colors = Colors();
        
        for(int i = 0; i < colors.Length; i++){
            
            if(colors[i] == color){
                return i;
            }
        }
        return -1;
    }

    public static string[] Colors()
    {
        string[] colorArray = {
            "black",
            "brown",
            "red",
            "orange",
            "yellow",
            "green",
            "blue",
            "violet",
            "grey",
            "white"
        };

        return colorArray;
    }
}