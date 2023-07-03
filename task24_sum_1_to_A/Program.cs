int SumFromAToB (int start, int finish)
{
    int sum = 0;
    for (int i = start; i <= finish; i++)
    {
        sum += i;
    }
    return sum;
}

System.Console.WriteLine(SumFromAToB(3, 10));