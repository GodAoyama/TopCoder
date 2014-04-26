using System;
using System.Linq;
using System.Collections.Generic;

public class EllysSortingTrimmer
{
    public string getMin(string S, int L)
    {
        for (int i = S.Length-L; i >= 0; i--)
        {
            char[] tmpStr = S.Substring(i,L).ToCharArray();
            Array.Sort(tmpStr);
            S = S.Substring(0, i) + new string(tmpStr);
        }
        return S;
    }
}