using System;
using System.Collections.Generic;
using System.Linq;

public class LargestSubsequence
{
    public string getLargest(string s)
    {
        int pos = 0;
        string largest = string.Empty;

        while(true)
        {
            if (pos >= s.Length)
                break;
            for (int i = pos; i < s.Length; i++)
                pos = s[pos] < s[i] ? i : pos;

            largest += s[pos].ToString();
            pos++;
        }
        return largest;
    }
}