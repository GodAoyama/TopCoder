public class PairGameEasy
{
    private bool Next(int a, int b, int c, int d)
    {
        if (a == c && b == d)
            return true;
        if (a > c || b > d)
            return false;

        return Next(a + b, b, c, d) || Next(a, a + b, c, d);
    }
    public string able(int a, int b, int c, int d)
    {
        return Next(a, b, c, d) ? "Able to generate" : "Not able to generate";
    }
}