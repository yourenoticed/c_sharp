// Returns a week day from an inserted number

Console.Write("Enter a number: ");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday == 1) Console.WriteLine("Monday");
else if (weekday == 2) Console.WriteLine("Tuesday");
else if (weekday == 3) Console.WriteLine("Wednesday");
else if (weekday == 4) Console.WriteLine("Thursday");
else if (weekday == 5) Console.WriteLine("Friday");
else if (weekday == 6) Console.WriteLine("Saturday");
else if (weekday == 7) Console.WriteLine("Sunday");
else Console.WriteLine("Not valid weekday");