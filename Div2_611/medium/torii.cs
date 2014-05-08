using System;
using System.Linq;
using System.Collections.Generic;

public class LCMSetEasy
{
    private long gcd(long x, long y)
    {
        while(x != y && x != 0 && y != 0)
        {
            if (y > x)
                y %= x;
            else
                x %= y;
        }

        return Math.Max(x,y);
    }
    
    private long lcm(long x,long y)
    {
        return x * y / gcd(x, y);
    }
    
    public string include(int[] S, int x)
    {
        List<int> list = S.Where(v => x%v == 0).ToList();

        long currentGCD = 1; //最悪の場合のlcm == 1
        foreach(int v in list)
            currentGCD = lcm(currentGCD, v);

        return currentGCD == x ? "Possible" : "Impossible";
    }
}