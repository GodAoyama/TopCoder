using System;
public class FormatAmt
{
	public string amount(int dollars, int cents)
	{
	string ans="";
	string dol,cen;
	dol = dollars.ToString();
	cen = cents.ToString();
	
	for(int i=0; i<dol.Length; i++)
	{
		ans = dol[dol.Length - i - 1] + ans;
		if(i%3 == 2 && i!=dol.Length-1)
		{
		ans =  "," + ans;
		}
	}
	
	ans = ans + ".";
	
	if(cents < 10)
	{
		ans = ans + "0" + cen[0].ToString();
	}
	else
	{
		ans = ans + cen[0].ToString() + cen[1].ToString();
	}

	
	ans = "$" + ans;
	return ans;
	}
};