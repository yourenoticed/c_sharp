Console.Write("Enter a number representing a day of a week: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 5 && day < 8)
{
    Console.WriteLine($"The {day}th day of the week is weekend");
}
else Console.WriteLine($"The {day} day isn't weekend");