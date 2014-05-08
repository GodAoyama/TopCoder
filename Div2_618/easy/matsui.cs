using System;
using System.Collections;


public class WritingWords 
{

    public int write(string word) 
    {
        int zero = (int)(('A') - '0') - 1;
        int sum = 0;
        for (int i = 0; i < word.Length; i++) 
        {
            sum += (int)(word[i] - '0') - zero;
        
        }
        return sum;
    
    }

}