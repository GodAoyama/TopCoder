using System;
using System.Linq;
using System.Collections.Generic;

public class DivideByZero
{
    public int CountNumbers(int[] numbers)
    {
        List<int> numList = new List<int>(numbers);
        numList.Sort();

        int i = numList.Count() - 1;
        while(true)
        {
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
                    numList.Sort();
                    i = numList.Count();
                    break;
                }
            }
            i--;
        }
        return numList.Count();
    }
}