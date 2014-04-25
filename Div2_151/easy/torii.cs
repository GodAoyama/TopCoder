using System;

public class PrefixCode
{
    public string isOne(string[] words)
    {
        int index = int.MaxValue;
        for(int i =0; i < words.Length; i++)
        {
            for(int j = 0; j < words.Length; j++)
            {
                if(i == j) 
                    continue;
                if(words[i].Length <= words[j].Length)
                {
                    if(words[i] == words[j].Substring(0,words[i].Length))
                        index = Math.Min(index,i);
                }
            }
        }

        if(index == int.MaxValue)
            return "Yes";
        else
        {
            return "No, " + index.ToString();
        }
    }
}