using System;

public class WolvesAndSheep
{       
    //0番目と1番目の間に柵を設けるときは1を返す
    private int ColumnFencePos(int i, int j, string[] field)
    {
        char opposite = field[i][j] == 'S' ? 'W' : 'S';
        int ii = i-1;
        bool wolf = false;
        while(true)
        {
            if (ii < 0)
                return -1;
            if (field[ii][j] != opposite)
                ii--;
            else
            {
                wolf = true;
                break;
            }
        }
        return wolf ? ii + 1 : -1;
    }

    private int RowFencePos(int i, int j, string[] field)
    {
        char opposite = field[i][j] == 'S' ? 'W' : 'S';
        int jj = j - 1;
        bool wolf = false;
        while (true)
        {
            if (jj < 0)
                return -1;
            if (field[i][jj] != opposite)
                jj--;
            else
            {
                wolf = true;
                break;
            }
        }
        return wolf ? jj + 1 : -1;
    }

    public int getmin(string[] field)
    {
        int columnFence = 0, rowFence = 0;
        //first, column
        for (int i = field.Length-1; i > 0; i--)
        {
            int minPos = 0;
            for (int j = 0; j < field[0].Length; j++)
            {
                if (field[i][j] == 'S' || field[i][j] == 'W')
                    minPos = Math.Max(minPos, ColumnFencePos(i, j, field));
            }

            if(minPos != 0 && minPos <= i)
            {
                columnFence++;
                i = minPos;
            }
        }

        //next, row
        for (int j = field[0].Length - 1; j > 0; j--)
        {
            int minPos = 0;
            for (int i = 0; i < field.Length; i++)
            {
                if (field[i][j] == 'S' || field[i][j] == 'W')
                    minPos = Math.Max(minPos, RowFencePos(i, j, field));
            }

            if (minPos != 0 && minPos <= j)
            {
                rowFence++;
                j = minPos;
            }
        }
        return columnFence + rowFence;
    }
}
