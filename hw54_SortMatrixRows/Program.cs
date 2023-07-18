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

void SortMatrixRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sorted = 0;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - sorted - 1; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
            sorted++;
        }
    }
}

// decided to also add matrix sorting algorythm

void SortMatrix(int[,] matrix)
{
    int sorted = 0;
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(0) - 1 - sorted; j++)
        {
            if (matrix[j, 0] > matrix[j + 1, 0])
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    int temp = matrix[j, k];
                    matrix[j, k] = matrix[j + 1, k];
                    matrix[j + 1, k] = matrix[j, k];
                }
            }
        }
        sorted++;
    }
}

int[,] matrix = CreateAndFillMatrix(4, 5, 0, 9);
PrintMatrix(matrix);
SortMatrixRows(matrix);
Console.WriteLine();
PrintMatrix(matrix);
SortMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);