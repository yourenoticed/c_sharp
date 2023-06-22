// Gets three numbers and outputs the max
Console.WriteLine("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 >= number2 && number1 >= number3) Console.WriteLine(number1);
else if (number2 >= number1 && number2 >= number3) Console.WriteLine(number2);
else if (number3 >= number1 && number3 >= number2) Console.WriteLine(number3);

