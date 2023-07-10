int count = 0;
while (true)
{
    int enteredText = 0;
    System.Console.Write("Enter an integer number (or anything to quit): ");
    try
    {
        enteredText = Convert.ToInt32(Console.ReadLine());
    }
    catch(System.FormatException)
    {
        break;
    }
    if (enteredText > 0)
        count++;
    
}
System.Console.WriteLine($"Amount of positive numbers: " + count);