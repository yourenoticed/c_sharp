int[] FillArray(int size, int start, int end) // also prints it out
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    PrintArray(result);
    return result;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.WriteLine($"{array[i]}]");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
}

int[] ProductOfPairs(int[] numbers)
{
    if (numbers.Length % 2 == 0)
    {
        int[] products = new int[numbers.Length / 2];
        for (int i = 0; i < products.Length; i++)
        {
            products[i] = numbers[i] * numbers[numbers.Length - i - 1];
        }
        return products;
    }
    else
    {
        int[] products = new int[numbers.Length / 2 + 1];
        for (int i = 0; i < products.Length; i++)
        {
            if (i == products.Length - 1)
            {
                products[i] = numbers[i];
            }
            else
            {
                products[i] = numbers[i] * numbers[numbers.Length - i - 1];
            }
        }
        return products;
    }
    
}

PrintArray(ProductOfPairs(FillArray(25, 1, 10)));