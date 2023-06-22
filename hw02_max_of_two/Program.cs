// Gets two inputted numbers and outputs which one is max and min
Console.WriteLine("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2)
{
    Console.WriteLine(number2 + " is bigger than " + number1);
}
else if (number1 > number2)
{
    Console.WriteLine(number1 + " is bigger than " + number2);
}
else Console.Write("The numbers are equal");
