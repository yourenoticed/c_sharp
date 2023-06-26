Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit3 = number / 100 % 10;
if (digit3 != 0)
{
    Console.WriteLine(digit3);
}
else Console.WriteLine("There's no third digit");