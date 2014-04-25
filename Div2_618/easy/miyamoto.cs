using System;
using System.Linq;
using System.Collections;

class LongWordsDiv2
{
    public string find(string word)
    {
        bool ans = true;
        string a = "";
        string b = "";


        for (int i = 0; i < word.Length - 1; i++)
        {
            if (word[i] == word[i + 1])
            {
                return "Dislikes";
            }
        }


        for (int i = 0; i < word.Length - 1; i++)
        {
            for (int j = i + 1; j < word.Length; j++)
            {
                //System.Console.WriteLine("i = " + i + " j = " + j);
                if (word[i] == word[j])
                {
                    a = word.Substring(i + 1, j - i);
                    b = word.Substring(j + 1, word.Length - j + 1);

                }

                foreach (char c1 in a)
                {
                    foreach (char c2 in b)
                    {
                        if (c1 == c2)
                        {
                            return "Dislikes";
                        }
                    }
                }


                a = "";
                b = "";


            }

            
        }


            if (ans == true)
            {
                return "Likes";
            }
            else
            {
                return "Dislikes";
            }
    }
    
}

