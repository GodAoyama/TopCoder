using System;
public class WidgetRepairs
{
    public int days(int[] arrivals, int numPerDay)
    {
        int stock=0;
        int ans=0;
        for(int i=0; i<arrivals.Length; i++)
        {
            stock += arrivals[i];

            if(stock!=0)
            {
                ans++;
            }
            stock -= numPerDay;
            if(stock<0)
            {
                stock=0;
            }

        }
        while(stock>0)
        {
            stock -= numPerDay;
            ans++;
        }
        return ans;
    }
};