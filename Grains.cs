public static class Grains
{
    public static ulong Square(int n)
    {
        ulong res = 1;
        if (n <= 0||n>64)
        {
            throw new ArgumentOutOfRangeException(nameof(n), "Square must be between 1 and 64.");
        }
        if (n == 1)
        {
            return res;
        }
        for (int i = 1; i < n; i++)
        {
            res *= 2;
        }
        return res;
    }

    public static ulong Total()
    {
        return ulong.MaxValue;
    }
}
