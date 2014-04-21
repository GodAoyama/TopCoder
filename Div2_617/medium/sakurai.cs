using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SlimeXSlimonadeTycoon
{

    public static int[] stocks(int[] stock, int cust)//sell older limonade
    {
        while (true)
        {
            for (int i = 0; i < stock.Length; i++)
            {
                if (stock[i] >= cust)
                {
                    stock[i] -= cust;
                    return stock;
                }
                else if (cust > stock[i])
                {
                    cust -= stock[i];
                    stock[i] = 0;
                }
            }
        }
    }

    public static int sell(int[] morning, int[] customoers, int stale_limit)
    {

        int answer = 0;
        int stock = 0;
        int[] stock2 = Enumerable.Repeat(0, morning.Length).ToArray();

        for (int day = 0; day < morning.Length; day++)
        {
            if (day - stale_limit >= 0)//throw away staled limonade
            {
                stock -= stock2[day - stale_limit];
                stock2[day - stale_limit] = 0;
            }

            stock += morning[day];//produce new limonade
            stock2[day] = morning[day];//and memo when i make it

            if (stock >= customoers[day])
            {
                stock2 = stocks(stock2, customoers[day]);//sell older
                stock -= customoers[day];//and decrease stock
                answer += customoers[day];
            }
            else if (stock < customoers[day])
            {
                stock2 = stocks(stock2, stock);//sell all!
                answer += stock;
                stock = 0;
            }

        }

        return answer;
    }