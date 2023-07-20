int PrintAToB(int start, int finish)
{
    if (finish == start)
    {
        System.Console.WriteLine(finish);
        return finish;
    }
    else
    {
        System.Console.Write($"{start}, ");
        return PrintAToB(start + 1, finish);
    }
}

PrintAToB(1, 5);