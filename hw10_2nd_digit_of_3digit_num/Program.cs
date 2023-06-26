Console.Write("Enter a 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number >= 100)
{
    Console.WriteLine($"The second digit of number {number} is {number / 10 % 10}");
}