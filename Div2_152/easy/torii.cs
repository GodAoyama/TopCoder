using System;

public class FixedPointTheorem
{
    private double f(double x,double R)
    {
        return R * x * (1 - x);
    }
    
    public double cycleRange(double R)
    {
        double x = 0.25;
                
        double lowest = double.MaxValue;
        double highest = double.MinValue;

        for (int i = 0; i < 201000; i++)
        {
            x = f(x, R);

            if (i > 200000)
            {
                highest = Math.Max(x, highest);
                lowest = Math.Min(lowest, x);
            }
        }
        return highest - lowest;
    }         
}