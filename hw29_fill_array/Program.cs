int[] CreateAndFillArray(int size, int ranStart, int ranFinish)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(ranStart, ranFinish + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) {
        if (i == array.Length - 1){
            Console.WriteLine($"{array[i]}]");
        }
        else {
            Console.Write($"{array[i]}, ");
        }
    }
}

PrintArray(CreateAndFillArray(8, 1, 100));