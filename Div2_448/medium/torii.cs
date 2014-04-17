//time exceeded...

using System.Collections;

public class TheCardShufflingDivTwo
{
    public int shuffle(int n, int m)
    {
        Stack mainDeck = new Stack();
        Stack leftDeck = new Stack();
        Stack rightDeck = new Stack();
    
        for(int i = n; i >= 1; i--)
        {
            mainDeck.Push(i);
        }
        while(m > 0)
        {
            for(int i = 0; i< n; i++)
            {
                if(i%2 == 0)
                    leftDeck.Push(mainDeck.Pop());
                else
                    rightDeck.Push(mainDeck.Pop());
            }
        
            while(leftDeck.Count > 0)
            {
                mainDeck.Push(leftDeck.Pop());
            }
            while(rightDeck.Count > 0)
            {
                mainDeck.Push(rightDeck.Pop());
            }
        
            m--;
        }
    
        return (int)mainDeck.Pop();
    }
}