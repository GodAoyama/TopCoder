using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class ExerciseMachine 
{
    public int getPercentages(string time)
    {
        int hour = (int)(time[0] - '0') * 10 + (int)(time[1] - '0');
        int min = (int)(time[3] - '0') * 10 + (int)(time[4] - '0');
        int sec = (int)(time[6] - '0') * 10 + (int)(time[7] - '0');
        int sumSec = hour * 3600 + min * 60 + sec;

        int gcd = Gcd(sumSec, 100);

        if (gcd == 1) 
        {
            return 0;
        }

        int returnInt = (int)(100 / gcd);
        int sum = returnInt;
        int count = 0;
        while(sum < 100)
        {
            sum += returnInt;
            count++;
        }

        return count;
        
    }

    static int Gcd(int a, int b) 
    {
        if (a < b)
            return Gcd(b, a);
        int d = 0;

        do
        {
            d = a % b;
            a = b;
            b = d;
        } while (d != 0);

        return a;
    }

}