/* Напишите программу, которая будет принимать 
на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число некратно первому, 
то программа выводит остаток от деления. */

Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 % number2 == 0)
{
    Console.WriteLine($"Number {number1} is divisible by {number2}");
}
else
{
    Console.WriteLine($"Number {number1} isn't divisible by {number2}. The remainder is {number1 % number2}");
}