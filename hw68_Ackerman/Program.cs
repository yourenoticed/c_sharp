int Ackerman(int m, int n) // the args are reversed
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Ackerman(1, n - 1);
    }
    else
    {
        return Ackerman(Ackerman (m - 1, n), n - 1);
    }
}

Console.WriteLine(Ackerman(2, 3));