int AmountOfDigits (int number)
{
    int amount = 0;
    while (number > 0)
    {
        amount++;
        number /= 10;
    }
    return amount;
}

Console.WriteLine(AmountOfDigits(78));