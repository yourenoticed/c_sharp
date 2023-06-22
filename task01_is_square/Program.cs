/*
Напишите программу, которая на вход принимает два числа и проверяет,
является ли первое число квадратом второго.
*/
Console.Write("Enter a number you want to check for being a square: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number you want to check if it's a square of the first one: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 * number2 == number1)
{
    Console.Write("Number ");
    Console.Write(number1);
    Console.Write(" is a square of ");
    Console.WriteLine(number2);
}
else
{
    Console.Write("Number ");
    Console.Write(number1);
    Console.Write(" isn't a square of ");
    Console.WriteLine(number2);
}