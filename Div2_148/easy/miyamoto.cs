using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

public class DivisorDigits
{
    public int howMany(int number)
    {
        int ans = 0;

        string str = number.ToString();

        for (int i = 0; i < str.Length; i++)
        {
            if (((int)str[i] - '0') == 0)
            {
                continue;
            }

            if (number % ((int)str[i] - '0') == 0)
            {
                ans++;
            }

        }



        return ans; 
    }
};
