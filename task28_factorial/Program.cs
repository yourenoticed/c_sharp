int Factorial(int n)
{
    int fact = 1;
    for (int i = 1; i <= n; i++)
    {
        fact *= i;
    }
    return fact;
}

Console.Write("Enter a number of factorial: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{number}! = {Factorial(number)}");