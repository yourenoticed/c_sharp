int number = new Random().Next(10, 100);
int digit1 = number / 10;
int digit2 = number % 10;
if (digit1 > digit2)
{
    Console.WriteLine($"The max digit is {digit1}");
}
else if (digit1 < digit2)
{
    Console.WriteLine($"The max digit is {digit2}")
}
else Console.WriteLine($"The digits of the number {number} are equal")