int PrintAToB(int start, int finish)
{
    if (finish == start)
    {
        Console.WriteLine(finish);
        return finish;
    }
    else
    {
        Console.Write($"{start}, ");
        return PrintAToB(start + 1, finish);
    }
}

PrintAToB(1, 5);