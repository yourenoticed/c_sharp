int SumOfDigits(int number)
{
    int sumOfDigits = 0;
    while (number > 0)
    {
        sumOfDigits += number % 10;
        number /= 10;
    }
    return sumOfDigits;
}

System.Console.WriteLine(SumOfDigits(12345));