public class WritingWords
{
    public int write(string word)
    {
        int touch = 0;

        foreach(char v in word)
        {
            touch+=v-'A'+1;
        }
        return touch;
    }
}