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

int AmountOfEvenNums(int[] nums)
{
    int amount = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0)
        {
            amount++;
        }
    }
    return amount;
}

System.Console.WriteLine($"Amount of even numbers in the array: {AmountOfEvenNums(FillArray(40, 100, 999))}");