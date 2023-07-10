int[] Fibonacci(int n) // returns fib array and prints it
{
    int[] fib = new int[n];
    fib[0] = 0;
    if (n > 1)
    {
        fib[1] = 1;
        for (int i = 2; i < n; i++)
            fib[i] = fib[i - 1] + fib[i - 2];
    }
    PrintArray(fib);
    return fib;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.WriteLine($"{array[i]}]");
        else
            Console.Write($"{array[i]}, ");
    }
}

int[] fibonacci = Fibonacci(15);