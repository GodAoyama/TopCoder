using System;
public class MostProfitable
{
    public string bestItem(int[] costs, int[] prices, int[] sales, string[] items)
    {
        int maxSum = 0;
        int id = -1;
        for(int i = 0; i < costs.Length; i++)
        {
            int tmp = (prices[i] - costs[i]) * sales[i];
            if (maxSum < tmp)
            {
                maxSum = tmp;
                id = i;
            }
        }

        if (id == -1)
            return "";
        else
            return items[id];
    }
}