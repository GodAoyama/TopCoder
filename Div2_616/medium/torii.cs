using System.Collections.Generic ;

public class ColorfulCoinsEasy
{
    public string isPossible(int[] values)
    {
        List<int> list = new List<int>();
        for(int i = 0; i < values.Length-1; i++)
            list.Add(values[i+1]/values[i]);
        list.Sort();
        
        for(int i = 0; i < list.Count; i++)
        {
            if( i >= list[i]-1)
                return "Impossible";
        }
        
        return "Possible";
    }
}