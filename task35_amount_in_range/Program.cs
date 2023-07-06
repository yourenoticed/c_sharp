/* Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
значения которых лежат в отрезке [10,99]. */

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

int AmountOfNumbersInRange(int[] array, int start, int end)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= start) && (array[i] <= end))
        {
            amount++;
        }
    }
    return amount;
}

int start = 5;
int end = 99;
System.Console.WriteLine($"Amount of numbers in range [{start}, {end}] is {AmountOfNumbersInRange(FillArray(123, -69, 420), start, end)}");