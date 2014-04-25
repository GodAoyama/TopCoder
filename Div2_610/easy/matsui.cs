using System;
using System.Collections;


public class DivideByZero 
{
    public int CountNumbers(int[] numbers) 
    {
        int temp = 0;
        bool same = false;
        ArrayList array = new ArrayList();
        
        Array.Sort(numbers);
        for(int i = 0; i <numbers.Length; i++)
        {
            array.Add(numbers[i]);
        }

        for (int i = 0; i < array.Count; i++) 
        {
            for (int j = 0; j < array.Count; j++)
            {
                temp = 0;
                same = false;

                if ((int)array[i] > (int)array[j])
                {
                    temp = (int)((int)array[i] / (int)array[j]);
                    for (int k = 0; k < array.Count; k++)
                    {
                        if ((int)array[k] == temp) 
                        {
                            same = true;
                        }
                    }

                }
                else if ((int)array[j] > (int)array[i])
                {
                    temp = (int)((int)array[j] / (int)array[i]);
                    for (int k = 0; k < array.Count; k++)
                    {
                        if ((int)array[k] == temp)
                        {
                            same = true;
                        }
                    }
                }
                else 
                {
                    same = true;
                }

                if (same == false) 
                {
                    array.Add(temp);
                }
             
            }
        }
            return array.Count;
    
    }


}