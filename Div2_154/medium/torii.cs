using System;
public class SuperRot
{
    public string decoder(string message)
    {
        string answer = string.Empty;
        string ALPHA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        foreach(char v in message)
        {
            if ('0' <= v && v <= '9')
                answer += ((int.Parse(v.ToString()) + 5) % 10).ToString();
            else if ('a' <= v && v <= 'z')
                answer += ALPHA[(v - 'a' + 13) % 26].ToString().ToLower();
            else if ('A' <= v && v <= 'Z')
                answer += ALPHA[(v - 'A' + 13) % 26].ToString();
            else
                answer += v.ToString();
        }

        return answer;
    }
}