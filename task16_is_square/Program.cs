Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 / number2 == number2 || number2 / number1 == number1)
{
    Console.WriteLine("True");
}
else Console.WriteLine("False");