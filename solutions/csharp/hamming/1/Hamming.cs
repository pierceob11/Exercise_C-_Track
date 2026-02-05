using System;

public static class Hamming
{

    private static int _hammingDistance = 0;
        
    public static int Distance(string firstStrand, string secondStrand)
    {
        int _hammingDistance = 0;

        if(firstStrand.Length != secondStrand.Length){
            throw new ArgumentException("...");
        }
        else{
            for(int i = 0; i < firstStrand.Length; i++){
                char a = firstStrand[i];
                char b = secondStrand[i];
                if(a != b) _hammingDistance++;
            }
            return _hammingDistance;
            }
        }
}
