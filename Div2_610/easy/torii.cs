using System;
using System.Linq;
using System.Collections.Generic;

public class DivideByZero
{
    public int CountNumbers(int[] numbers)
    {
        List<int> numList = new List<int>(numbers);

        int i = numList.Count() - 1;
        while(true)
        {
            numList.Sort();
            if (i <= 0)
                break;
            for(int j = i-1; j >= 0; j--)
            {
                int c = numList[i] / numList[j];
                if (numList.Select(s => s).Any(s => s == c))
                    continue;
                else
                {
                    numList.Add(c);
                    i = numList.Count();
                    break;
                }
            }
            i--;
        }
        return numList.Count();
    }
}