using System;
public class ProfitCalculator
{
    public int percent(string[] items)
    {
        double sum = 0;
        double priceSum = 0;

        for(int i =0 ; i < items.Length; i++)
        {
            double price = double.Parse(items[i].Substring(0, 6));
            double cost = double.Parse(items[i].Substring(7, 6));
            sum += price - cost;
            priceSum += price;
        }

        return (int)(sum/priceSum*100);
    }
}