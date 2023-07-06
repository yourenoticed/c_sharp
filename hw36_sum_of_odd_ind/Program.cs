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

int SumOfOddIndexedElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.WriteLine($"Sum of odd indexed elements in the array is {SumOfOddIndexedElements(FillArray(13, -10, 666))}");