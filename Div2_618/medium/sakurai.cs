using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class LongWordsDiv2
{

    public static string find(string word)
    {
        bool like = true;

        for (int i = 0; i < word.Length - 1; i++)
        {
            if (word[i] == word[i + 1])
            {
                return "Dislikes";
            }
        }

        char search;
        int sub;
        char search_sub;
        string left, right;
        for (int i = 0; i < word.Length - 2; i++)
        {
            search = word[i];
            for (int j = i + 2; j < word.Length - 1; j++)
            {
                if (word[j] == search)
                {
                    sub = j;
                    left = word.Substring(i + 1, sub - i - 1);
                    right = word.Substring(sub + 1, word.Length - sub - 1);
                    for (int n = 0; n < left.Length; n++)
                    {
                        search_sub = word[i + 1 + n];
                        for (int m = 0; m < right.Length; m++)
                        {
                            if (word[sub + 1 + m] == search_sub)
                            {
                                like = false;
                            }
                        }
                    }
                }
            }
        }
        if (like)
        {
            return "Likes";
        }
        else
        {
            return "Dislikes";
        }
    }
}