using System;

public class FormatAmt
{
    public string amount(int dollars, int cents)
    {
        string str = dollars.ToString();
        string centStr = cents.ToString();
        if(centStr.Length == 1)
            centStr = "0" + centStr;
        string result = string.Empty;

        int count = 0;
        for(int i = str.Length-1; i >= 0; i--)
        {
            result = str[i].ToString() + result;
            count = (count+1) % 3;
            if(count == 0 && i != 0)
                result = "," + result;
        }

        return "$" + result + "." + centStr;
    }
}