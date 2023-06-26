Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"The number {number} is divisible by 7 and 23");
}
else Console.WriteLine($"The number {number} isn't divisible by 7 and 23");
