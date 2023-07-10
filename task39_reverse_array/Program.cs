int[] FillArray(int size, int start, int end) // also prints it out
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(start, end + 1);
    PrintArray(array);
    return array;
}

void PrintArray(int[] array, string name = "")
{
    Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

int[] ReverseArray(int[] array)
{
    int[] revArray = new int[array.Length];
    for (int i = 0; i < revArray.Length; i++)
        revArray[i] = array[array.Length - 1 - i]; 
    return revArray;
}

int[] array = FillArray(11, -100, 100);
PrintArray(ReverseArray(array));