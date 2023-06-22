// Prints out all even nums in range 1 to n
Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1)
{
    for (int i = 1; i <= number; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
}
else
{
    for (int i = 1; i >= number; i--)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
}