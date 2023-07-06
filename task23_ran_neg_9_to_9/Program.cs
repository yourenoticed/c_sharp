int[] SumOfPosAndNegVals(int[] numbers)
{
    int sum_neg = 0;
    int sum_pos = 0;
    foreach (int n in numbers)
    {
        if (n < 0)
        {
            sum_neg += n;
        }
        else
        {
            sum_pos += n;
        }
    }
    int[] sums = {sum_pos, sum_neg};
    return sums;
}

int[] FillArray10To99(int size, int deviation)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(-deviation, deviation + 1);
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

int[] array = FillArray10To99(10, 9);
PrintArray(SumOfPosAndNegVals(array));