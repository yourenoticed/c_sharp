// Gets the 3-digit number and returns its last digit
Console.Write("Enter a 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    Console.Write("The last digit of number ");
    Console.Write(number);
    Console.Write(" is ");
    Console.WriteLine(number % 10);
}
else Console.WriteLine("A three-digit one...");