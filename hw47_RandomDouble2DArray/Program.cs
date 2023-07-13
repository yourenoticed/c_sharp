double[,] CreateAndFillMatrix(int rows, int columns, double start, double end)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().NextDouble() * (end - start) + start;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
            Console.Write($"[{i}]\t");
    }    
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"[{i}]");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,8:N2}", matrix[i, j], "\t");
        }
        Console.WriteLine();
    }   
}

double[,] doubles = CreateAndFillMatrix(4, 11, -4.3, 5.6);
PrintMatrix(doubles);