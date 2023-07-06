/* Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. */

int[] FillArray10To99(int size) // also prints it out
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(10, 20);
    }
    PrintArray(result);
    return result;
}

void PrintArray(int[] array) {
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

bool IsInArray(int[] array, int target)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == target)
        {
            return true;
        }
    }
    return false;
}

int[] numbers = FillArray10To99(15);

for (int i = 10; i <= 19; i++)
{
    System.Console.WriteLine($"Target: {i} => {IsInArray(numbers, i)}");
}