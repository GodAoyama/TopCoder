using System;
public class WidgetRepairs
{
    public int days(int[] arrivals, int numPerDay)
    {
        int stack = 0;
        int day = 0;
        foreach(int task in arrivals)
        {
            if(stack == 0 && task == 0)
                    continue;
            else
            {
                stack = Math.Max(0,stack + task - numPerDay);
                day++;
            }
        }

        if (stack != 0)
        {
            if(stack % numPerDay == 0)
                day += (stack / numPerDay);
            else
                day += (stack / numPerDay)+1;
        }
        return day;
    }
}