using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class WritingWords
{

    public static int write(string word)
    {
        int ans = 0;
        int a = 0;

        for (int i = 0; i < word.Length; i++)
        {
            a = Convert.ToChar(word[i]) - 64;
            ans += a;
        }
        return ans;
    }
}