string Cubes(int n)
{
    string cubes = "1";
    if (n > 2)
    {
        for (int i = 2; i <= n; i++)
        {
            cubes = $"{cubes}, {i * i * i}";
        }
    }
    else
    {
        for (int i = 0; i >= n; i--)
        {
            cubes = $"{cubes}, {i * i * i}";
        } 
    }
    return cubes;
}

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Cubes(number) + ".");