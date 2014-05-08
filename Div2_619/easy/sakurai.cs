using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GoodCompanyDivTwo
{
    public static int countGood(int[] superior, int[] workType)
    {
        int[] ans = Enumerable.Repeat(1, superior.Length).ToArray();

        for (int i = 0; i < superior.Length; i++)
        {
            int[] dep = Enumerable.Repeat(int.MaxValue, 100).ToArray();
            dep[i] = workType[i];
            for (int j = 0; j < superior.Length; j++)
            {
                if (superior[j] == i)
                {
                    dep[j] = workType[j];
                }
            }
            dep = dep.Where(s => s != int.MaxValue).ToArray();
            if (dep.Length != dep.Distinct().ToArray().Length)
            {
                ans[i] = 0;
            }
        }
        return ans.Sum();


    }

}