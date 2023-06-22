// Gets the 3-digit number and returns its last digit
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("The last digit of number ");
Console.Write(number);
Console.Write(" is ");
Console.WriteLine(number % 10);