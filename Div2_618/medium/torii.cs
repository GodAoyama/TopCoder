public class LongWordsDiv2
{
    bool[,] dp = new bool[0x80,0x80];
    const string like = "Likes";
    const string dislike = "Dislikes";
    private bool checkRepeat(char x, char y, string word)
    {
        for(int i = 0; i < word.Length; i++)
        {
            if(word[i] == x)
            {
                foreach(char v in word.Substring(i+1))
                {
                    if (v == y)
                        return false;
                }
            }
        }
        return true;
    }
    public string find(string word)
    {
        for (int i = 0; i < word.Length-1; i++ )
        {
            if (word[i] == word[i + 1])
                return dislike;
        }

        for (int i = 0; i < word.Length; i++)
        {
            for(int j = i+1; j <word.Length; j++)
            {
                if (!checkRepeat(word[i], word[j], word.Substring(j+1)))
                    return dislike;
            }
        }

        return like;
    }
}