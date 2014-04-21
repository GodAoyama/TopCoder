
using System;
public class DiskSpace
{
    public int minDrives(int[] used, int[] total)
    {
        int answer = 1;
        int amountUsed = 0;

        Array.Sort(total);
        for (int i = 0; i < used.Length; i++)
        {
            amountUsed += used[i];
        }

        for (int i = total.Length - 1; i >= 0; i--)
        {
            amountUsed -= total[i];
            if (amountUsed <= 0)
                break;

            answer++;
        }

        return answer;
    }
}