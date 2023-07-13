int[,] CreateAndFillMatrix(int rows, int columns, int start, int end)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(start, end + 1);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < matrix.GetLength(1); i++)
        Console.Write($"[{i}]\t");
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }   
}

void AvgOfCols(int[,] matrix)
{
    Console.Write("\t");
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        System.Console.Write("{0,6:N1}", $"{sum / matrix.GetLength(0)}\t");
    }
    Console.WriteLine();
}

int[,] numbers = CreateAndFillMatrix(5, 4, 1, 1123);
PrintMatrix(numbers);
AvgOfCols(numbers);