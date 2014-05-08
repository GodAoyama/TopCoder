using System;
using System.Collections.Generic;
using System.Linq;

public class LeftAndRightHandedDiv2
{
    public int count(string S)
    {
        int count = 0;

        for(int i = 0; i < S.Length-1; i++)
        {
            if (S[i] == 'R' && S[i + 1] == 'L')
                count++;
        }

        return count;
    }
}