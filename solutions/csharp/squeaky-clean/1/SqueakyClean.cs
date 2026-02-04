public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new System.Text.StringBuilder();

        for(int i = 0; i < identifier.Length; i++){
            char c = identifier[i];

            if(char.IsWhiteSpace(c)){
                sb.Append('_');
            }
            else if(char.IsControl(c)){
                sb.Append("CTRL");
            }
            else if(c == '-'){
                if(i + 1 < identifier.Length){
                    i++; // Skip to next character
                    sb.Append(char.ToUpper(identifier[i]));
                }
            }
            else if(!char.IsLetter(c) || c == '_'){
                continue;   
            }
            else if(c >= '\u0370' && c <= '\u03FF' && char.IsLower(c)){
                continue;
            }
            else
                sb.Append(c);
            
        }
        return sb.ToString();
    }
}
