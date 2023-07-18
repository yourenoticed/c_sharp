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

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int firstMatrixRows = firstMatrix.GetLength(0);
    int firstMatrixCols = firstMatrix.GetLength(1);
    int[,] matrixProduct = new int[firstMatrixRows, firstMatrixCols];
    if ((firstMatrixRows == secondMatrix.GetLength(1))
    && (firstMatrixCols == secondMatrix.GetLength(0)))
    {
        for (int i = 0; i < firstMatrixRows; i++)
        {
            for (int j = 0; j < firstMatrixCols; j++)
            {
                matrixProduct[i, j] = firstMatrix[i, j] * secondMatrix[j, i];
            }
        }
        PrintMatrix(matrixProduct);
    }
    else
    {
        Console.WriteLine("Can't multiply the matrixes");
    }
    return matrixProduct;
}

int[,] matrix1 = CreateAndFillMatrix(2, 3, 0, 9);
int[,] matrix2 = CreateAndFillMatrix(3, 2, 0, 9);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
int[,] matrixProducts = MatrixMultiplication(matrix1, matrix2); 
Console.WriteLine();