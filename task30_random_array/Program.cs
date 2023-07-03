/* 30. # Напишите программу, которая выводит массив и
з 8 элементов, заполненный нулями и единицами в случайном порядке. */
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

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

int[] array = FillArray(8);

/* for (int i = 0; i < size; i++)
{
    System.Console.Write($"{array[i]} ");
} */

PrintArray(array);