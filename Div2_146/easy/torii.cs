using System;

public class YahtzeeScore
{
    public int maxPoints(int[] toss)
    {
        int maxValue = 0;
        foreach(int v1 in toss)
        {
            int tmpPoints = 0;
            foreach(int v2 in toss)
            {
                if(v2 == v1)
                    tmpPoints += v2;
            }
        
            maxValue = Math.Max(maxValue,tmpPoints);        
        }
    
        return maxValue;
    }
}