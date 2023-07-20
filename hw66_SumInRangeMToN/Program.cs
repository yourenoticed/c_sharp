int SumInRangeMToN(int m, int n)
{
    if (m < n)
    {
        return m + SumInRangeMToN(m + 1, n);
    }
    else
    {
        return m;
    }
}

Console.WriteLine(SumInRangeMToN(4, 8));