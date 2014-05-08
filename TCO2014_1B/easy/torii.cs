using System;

public class SpamChecker
{
    public string spamCheck(string judgeLog, int good, int bad)
    {
        int score = 0;
        foreach(char c in judgeLog)
        {
            score += c == 'o' ? good : -bad;
            if (score < 0)
                return "SPAM";
        }
        
        return "NOT SPAM";
    }
}