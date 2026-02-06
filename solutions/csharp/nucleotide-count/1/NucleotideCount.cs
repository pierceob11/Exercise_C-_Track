using System;
using System.Collections.Generic;

public static class NucleotideCount
{

    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> dnaStrand = new Dictionary<char, int>();
        
        int aCount = 0;
        int cCount = 0;
        int gCount = 0;
        int tCount = 0;
        
        foreach(char c in sequence){
            if(c == 'A'){
                aCount++;
            }
            else if(c == 'C'){
                cCount++;
            }
            else if(c == 'G'){
                gCount++;
            }
            else if(c == 'T'){
                tCount++;
            }
            else{
                throw new ArgumentException("error");
            }
        }

        dnaStrand.Add('A', aCount);
        dnaStrand.Add('C', cCount);
        dnaStrand.Add('G', gCount);
        dnaStrand.Add('T', tCount);

        return dnaStrand;
    }
}