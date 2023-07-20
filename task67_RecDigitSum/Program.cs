int SumOfDigits(int number)
{
    if (number < 10)
    {
        return number;
    }
    else
    {
        return number % 10 + SumOfDigits(number / 10);
    }
}

System.Console.WriteLine(SumOfDigits(123430));