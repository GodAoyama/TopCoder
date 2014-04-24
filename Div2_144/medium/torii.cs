using System;

public class BinaryCode
{
    private int Num(char v)
    {
        return v - '0';
    }
    
    private string decoder(int n, string mes)
    {
        if (mes.Length == 1)
            return n.ToString() == mes ? mes : "NONE";

        int[] decodedNum = new int[mes.Length];        
        decodedNum[0] = n;
        decodedNum[1] = Num(mes[0]) - n;
    
        string answer = n.ToString() + decodedNum[1].ToString();

        for(int i = 0; i < mes.Length; i++)
        {
            if (i < 2)
            {
                if (decodedNum[i] != 0 && decodedNum[i] != 1)
                    return "NONE";
            }
            else
            {
                int tmp = Num(mes[i - 1]) - decodedNum[i - 1] - decodedNum[i - 2];
                if (tmp != 0 && tmp != 1)
                    return "NONE";
                decodedNum[i] = tmp;
                answer += decodedNum[i].ToString();
            }
        }

        if (Num(mes[mes.Length - 1]) != decodedNum[mes.Length - 1] + decodedNum[mes.Length - 2])
            return "NONE";
        return answer;
    }
    public string[] decode(string message)
    {
        string[] answer = new string[2];
        answer[0] = decoder(0,message);
        answer[1] = decoder(1,message);

        return answer;
    }
}