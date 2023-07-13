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

bool IsElementInArray(int[,] matrix, int posRow, int posCol)
{
    if ((posRow > matrix.GetLength(0) - 1) 
    || (posCol > matrix.GetLength(1) - 1))
    {
        return false;
    }
    Console.WriteLine($"({posRow},{posCol})th element is {matrix[posRow, posCol]}");
    return true;
}

int[,] numbers = CreateAndFillMatrix(4, 5, 1, 10);
PrintMatrix(numbers);
bool isInArray = IsElementInArray(numbers, 6, 2);
if (!isInArray)
{
    Console.WriteLine("Index is out of range");
}