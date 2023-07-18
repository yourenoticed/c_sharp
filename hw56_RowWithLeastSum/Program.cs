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

int[] RowWithLeastSum(int[,] matrix)
{
    Dictionary<int, int> rowsSums = new Dictionary<int, int>(); 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        rowsSums.Add(i, sum);
    }
    int maxSumRowIndex = 0;
    int maxSum = 0;
    foreach (int rowIndex in rowsSums.Keys)
    {
        if (rowsSums[rowIndex] > maxSum)
        {
            maxSum = rowsSums[rowIndex];
            maxSumRowIndex = rowIndex;
        } 
    }
    int[] rowWithLeastSum = new int[matrix.GetLength(1)];
    for (int i = 0; i < rowWithLeastSum.Length; i++)
    {
        rowWithLeastSum[i] = matrix[maxSumRowIndex, i];
    }
    return rowWithLeastSum;
}

void PrintArray(int[] array)
{
    Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {  
        if (i + 1 != array.Length)
            Console.Write($"{array[i]}, ");
        else
            Console.WriteLine($"{array[i]}]");
    }
}

int[,] matrix = CreateAndFillMatrix(4, 5, 0, 9);
PrintMatrix(matrix);
int[] minSumRow = RowWithLeastSum(matrix); 
Console.WriteLine();
PrintArray(minSumRow);