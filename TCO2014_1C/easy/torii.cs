using System;
using System.Collections.Generic;
using System.Linq;

public class Unique
{

    public string removeDuplicates(string S)
    {
        string answer = string.Empty;
        foreach (char c in S.ToCharArray().Distinct())
            answer += c;

        return answer;
    }
}