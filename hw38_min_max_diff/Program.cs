double[] FillArray(int size, double start, double end) // also prints it out
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = (new Random().NextDouble() * (end - start)) + start;
    }
    PrintArray(result);
    return result;
}

void PrintArray(double[] array)
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

double MaxMinDifference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}

Console.WriteLine($"The difference between the maximum and minimum value of the array is {MaxMinDifference(FillArray(15, -1.6, 5.8))}");