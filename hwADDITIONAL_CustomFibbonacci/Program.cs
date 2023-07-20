void CustomFibonacci(int firstF, int secondF, int n)
{
    if (n > 1)
    {
        Console.Write(firstF + ", ");
        CustomFibonacci(secondF, firstF + secondF, n - 1);
    }
    else
    {
        Console.WriteLine(firstF);
    }
}

CustomFibonacci(6, 10, 4);