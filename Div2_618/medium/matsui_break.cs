using System;
using System.Collections;


public class LongWordsDiv2 
{

    public string find(string word) 
    {
        char look;
        ArrayList mae = new ArrayList(); ;
        ArrayList usiro = new ArrayList(); ;

        for (int i = 0; i < word.Length; i++) 
        {
            usiro.Clear();
            mae.Clear();
            look = word[i];
            for (int j = i + 1; j < word.Length; j++) 
            {
                if(look == word[j] && j == i + 1)
                {
                    return "Dislikes";
                }
                else if (look == word[j])
                {
                    for (int k = j + 1; k < word.Length; k++) 
                    {
                        usiro.Add(word[k]);
                    
                    }

                    for (int x = 0; x < mae.Count; x++) 
                    {

                        for (int y = 0; y < usiro.Count; y++) 
                        {
                            if ((char)mae[x] == (char)usiro[y]) 
                            {
                                return "Dislikes";
                            }
                        
                        }
                    }
                }
                else 
                {
                    mae.Add(word[j]);
                }
            }
        
        }


        return "Likes";
    
    }

}