using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

class ImageDithering
{
    string dithered;
    string[] screen;

       
    public int count(string dithered, string[] screen)
    {
       
        int ans = 0;


        for (int j = 0; j < dithered.Length; j++)
        {
            for (int i = 0; i < screen.Length; i++)
            {
                for (int k = 0; k < screen[i].Length; k++)
                {
                    if (dithered[j] == screen[i][k])
                    {
                        ans++;
                    }

                }
            }
        }

        

        return ans;
    }

        
}


