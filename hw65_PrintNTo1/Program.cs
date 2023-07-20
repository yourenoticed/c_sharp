void PrintNTo1(int n)
{
    if (n > 1)
    {
        Console.Write(n + ", ");
        PrintNTo1(n - 1);
    }
    else
    {
        Console.WriteLine("1");
    }
}

PrintNTo1(18);