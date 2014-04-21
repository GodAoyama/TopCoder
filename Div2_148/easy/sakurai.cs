using System;

public class DivisorDigits
{
    public int howMany(int number)
    {
        string s;
        int ans=0;
        s = number.ToString();
        System.Console.WriteLine(s);
        for(int i = 0; i<s.Length; i++)
        {	
        	if(((int)s[i]-48)!=0)
        	{
            	if(number%((int)s[i]-48)==0)
            	{
                	ans++;
            	}
            }
        }
        return ans;

    }
}