/* Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это невозможно,
программа должна вывести сообщение для пользователя. */

int[,] CreateAndFillMatrix(int rows, int columns, int start, int end)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(start, end + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ReplaceRowsAndColumns(int[,] matrix)
{
    try
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0 + i; j < matrix.GetLength(1); j++)
            {
                int temp = matrix[j, i];
                matrix[j, i] = matrix[i, j];
                matrix[i, j] = temp;
            }
        }
        PrintMatrix(matrix);
    }
    catch (System.IndexOutOfRangeException)
    {
        Console.WriteLine("Can't replace rows and columns");
    }
}

/* void ReplaceRowsAndColumns(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        Console.WriteLine("Can't replace rows and columns");
    }
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0 + i; j < matrix.GetLength(1); j++)
            {
                int temp = matrix[j, i];
                matrix[j, i] = matrix[i, j];
                matrix[i, j] = temp;
            }
        }
        PrintMatrix(matrix);
    }
} */

int[,] ReplaceRowsAndColumns(int[,] matrix)
{
    int[,] replaced = new int[matrix.GetLength(0), matrix.GetLength(0)];
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        Console.WriteLine("Can't replace rows and columns");
    }
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                replaced[i, j] = matrix[j, i];
            }
        }
        PrintMatrix(matrix);
    }
    return replaced
}

int[,] matrix = CreateAndFillMatrix(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
ReplaceRowsAndColumns(matrix);