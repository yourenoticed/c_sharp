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

void EvenIndexedElmsToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
        for (int j = 0; i < matrix.GetLength(1); j += 2)
        {
            try {
                matrix[i, j] *= matrix[i, j];
            }
            catch(System.IndexOutOfRangeException) {
                break;
            }    
        }
}

int[,] matrix = CreateAndFillMatrix(4, 4, 1, 10);
PrintMatrix(matrix);
EvenIndexedElmsToSquare(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);