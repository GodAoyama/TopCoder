using System;

public class CCipher
{
    public string decode(string cipherText, int shift)
    {
        string database = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string answer = string.Empty;
        foreach(char v in cipherText)
        {
            for(int i = 0; i < database.Length; i++)
            {
                if(v == database[i])
                    answer += database[(52+i-shift)%26].ToString();
            }
        }
    
        return answer;
    }
}