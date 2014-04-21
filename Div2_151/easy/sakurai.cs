using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PrefixCode
{

    public static string isOne(string[] words)
    {
        string s1, s2;
        int x=0;
        int idx=765;//tell me how to set big number!
        for (int i = 0; i < words.Length; i++)
        {
            s1=words[i];
            for(int j = 0; j < words.Length; j++)
            {
                s2=words[j];
                x = 0;
                while(s1[x]==s2[x] && s1.Length < s2.Length)
                {
                    if (x == s1.Length - 1)
                    {
                        idx = Math.Min(idx,i);
                        break;
                    }
                    x++;
                }
            }
        }

        if(idx==765)
        {
            return "Yes";
        }
        else
        {
            return "No, " + idx;
        }
    }
}