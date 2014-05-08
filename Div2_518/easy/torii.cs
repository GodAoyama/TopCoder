using System;
using System.Collections.Generic;
using System.Linq;

public class TwiceString
{
    public string getShortest(string s)
    {
        for(int i = 1; i < s.Length; i++)
        {
            string tmp = s.Substring(i);
            if (tmp == s.Substring(0, tmp.Length))
                return s.Substring(0, s.Length - tmp.Length) + s;
        }

        return s+s;
    }
}