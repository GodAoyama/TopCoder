using System;
using System.Linq;

class
WritingWords
{
    public int write(string word)
    {
        int ans = 0;
        System.Console.WriteLine((int)'A');
        for (int i = 0; i < word.Length; i++)
        {
            ans += word[i] - 64;
        }
            return ans;
    }
}