using System;
using System.Collections;


public class WidgetRepairs
{

    public static int days(int[] arrivals, int numPerDay)
    {
        int sum = 0;
        int day = 0;
        int add = 0;
        for (int i = 0; i < arrivals.Length; i++) 
        {
            if (sum == 0 && arrivals[i] == 0) 
            {
                continue;
            }
            else if (sum + arrivals[i] - numPerDay > 0)
            {
                sum = sum + arrivals[i] - numPerDay;
                day++;
            }
            else 
            {
                sum = 0;
                day++;
            }

        }

        if(sum > 0){
            if (sum % numPerDay != 0)
            {
                add = (int)(sum / numPerDay) + 1;
            }
            else 
            {
                add = (int)(sum / numPerDay);
            }
        }
        return add + day;
    }

    static void Main(string[] args) 
    {
        int[] arrivals =  new int[] { 10, 0, 0, 4, 20 };
        int numPerDay = 8;

        int temp = days(arrivals, numPerDay);

        Console.WriteLine(temp);
        Console.ReadLine();
    
    }    

}