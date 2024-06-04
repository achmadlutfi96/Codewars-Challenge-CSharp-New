using System.Collections.Generic;
using System.Linq;
using System;
public class DnaStrand
{
    public static string MakeComplement(string dna)
    {
        //Your code
        Dictionary<char,char> dnaDict = new Dictionary<char,char>(){
            { 'A', 'T' },
            { 'G', 'C' },
            { 'T', 'A' },
            { 'C', 'G' },
        };
        return string.Concat(dna.Select(x=>dnaDict[x]));
    }

    public static void Main(){
        Console.WriteLine(MakeComplement("ATTGC"));
    }
}