using System;
public class CCipher
{
	public string decode(string cipherText,int shift)
	{
		string ans = "";
		int[] dec = new int[cipherText.Length];
		for(int i=0; i<cipherText.Length; i++)
		{
			dec[i] = (int)cipherText[i];
			dec[i] -= shift;
			if(dec[i]<(int)'A')dec[i] += 26;
			char c = Convert.ToChar(dec[i]);
			ans = ans + c.ToString();
		}
	return ans;
	}
};