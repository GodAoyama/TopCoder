using System;
public class Salary
{
    private int Seconds(string str)
    {
        int h = int.Parse(str.Substring(0, 2));
        int m = int.Parse(str.Substring(3, 2));
        int s = int.Parse(str.Substring(6, 2));

        return h * 3600 + m * 60 + s;
    }
    public int howMuch(string[] arrival, string[] departure, int wage)
    {
        double salary = 0;
        int startOverwork = Seconds("18:00:00");
        int endOverwork = Seconds("06:00:00");

        for(int i = 0; i < arrival.Length; i++)
        {
            int start = Seconds(arrival[i]);
            int end = Seconds(departure[i]);
            int workingTime = end - start;

            int overWork = 0;

            if(start < endOverwork)
                overWork += Math.Min(end-start,endOverwork-start);
            if (startOverwork < end)
                overWork += Math.Min(end-start, end-startOverwork);

            salary += ((double)workingTime+overWork/2.0)*wage/3600;
        }

        return (int)salary;
    }
}