
using System;

public class YahtzeeScore
{
	public int maxPoints(int[] toss)
	{
		int ans = 0;
		int[] count = new int[7];
		for(int i=0;i<5;i++)
		{
		System.Console.WriteLine(toss[i]);
			count[toss[i]]++;
		}
		for(int i=1;i<7;i++)
		{
			if(ans<count[i]*i) ans = count[i]*i;
		}
	return ans;	
	}
};