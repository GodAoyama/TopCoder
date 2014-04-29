using System;
using System.Collections.Generic;
using System.Linq;

public class TaroString
{
    public string getAnswer(string S)
    {
        bool[] table = new bool[256];
        string answer = string.Empty;

        foreach(char v in S)
        {
            if (v == 'C' || v == 'A' || v == 'T')
                answer += v;
        }

        return (answer == "CAT") ? "Possible" : "Impossible";
    }
}