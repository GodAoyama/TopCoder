using System;
public class ImageDithering{
	public int count(String dithered,String[] screen){
		String dit,scr;
		int ans=0;
		for(int i=0;i<dithered.Length;i++){
			dit = dithered.Substring(i,1);
			for(int j=0;j<screen.Length;j++){
				for(int k=0;k<screen[0].Length;k++){
					scr = screen[j].Substring(k,1);
					if(dit==scr)ans++;
				}
			}
		}
		return ans;
	}
};