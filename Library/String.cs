using System;

public class String_Lib
{
    /// <summary>
    /// string型の変数のchar[]を取得
    /// </summary>
    public char[] getCharList(string str)
    {
        char[] charList = str.ToCharArray();

        return charList;
    }

    /// <summary>
    /// stringを数値に変換
    /// </summary>
    public int Str_Num(string str)
    {
        int value = int.Parse(str);

        //"4"など、一文字の場合は以下もあり
        int value2 = (int)(str[0] - '0');

        return value;
    }
}