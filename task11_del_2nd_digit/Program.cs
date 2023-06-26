int number = new Random().Next(100, 1000);
Console.WriteLine($"Random number is {number}");
Console.WriteLine($"The number without 2nd digit is {(number / 100) * 10 + (number % 10)}");
/* int digit1 = number / 100;
int digit3 = number % 10; 
int answer = digit1 * 10 + digit3; */

