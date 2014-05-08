using System;

public class YahtzeeScore 
{
    public int maxPoints(int[] toss) 
    {
        int tempNum = 0;
        int tempSum = 0;
        int count = 0;
        Array.Sort(toss);
        for (int i = 0; i < toss.Length; i++) 
        {
            if (tempNum != toss[i]) 
            {
                tempNum = toss[i];
                count = 1;
            }
            else if (tempNum == toss[i]) 
            {
                count++;
            }
            if (tempSum < tempNum * count) 
            {
                tempSum = tempNum * count;
            }
        }

        return tempSum;
    
    }

}