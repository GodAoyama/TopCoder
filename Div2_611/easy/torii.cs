using System;
using System.Linq;
using System.Collections.Generic;

public class InterestingNumber
{
    public string isInteresting(string x)
    {
        int[] count = new int[10];
        bool[] check = new bool[x.Length];

        foreach (char v in x)
            count[v - '0']++;

        if(count.Any(a => a != 2 && a != 0))
            return "Not interesting";

        for(int i = 0; i < x.Length; i++)
        {
            if (check[i])
                continue;
            int v = x[i] - '0';
            if (i + v + 1 >= x.Length && !check[i])
                return "Not interesting";
            if (x[i + v + 1] != x[i])
                return "Not interesting";

            check[i] = check[i + v + 1] = true;
        }

        return "Interesting";
    }
}