using System;
using System.Linq;

public class ColorfulCoinsEasy
{
    public static string isPossible(int[] values)
    {
        int[] num = Enumerable.Repeat(0, values.Length + 1).ToArray();

        for (int i = 0; i < values.Length - 1; i++)
        {
            for (int j = values.Length; j > 0; j--)
            {
                if (values[i] * j - values[i + 1] < 0 && num[j] == 0)
                {
                    num[j] = 1;
                    break;
                }
            }
        }
        if (num.Sum() == values.Length - 1)
        {
            return "Possible";
        }
        return "Impossible";
    }

}
