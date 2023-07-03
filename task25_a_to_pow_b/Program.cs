int AToPoWB(int a, int b)
{
    int temp = a;
    for (int i = 1; i < b; i++)
    {
        a *= temp;
    }
    return a;
}

System.Console.WriteLine(AToPoWB(2, 10));