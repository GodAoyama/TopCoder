using System;

public class DivisorDigits
{
    public int howMany(int number)
    {
        char[] str = number.ToString().ToCharArray();

        int count = 0;
        foreach(char v in str)
        {
            if (v == '0')
                continue;
            if (number % (v - '0') == 0)
                count++;
        }
    
        return count;
    }
}