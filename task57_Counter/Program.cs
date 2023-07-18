/* Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том,
сколько раз встречается элемент входных данных */

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

void CountElementsInMatrix(int[,] matrix, Dictionary<int, int> counter)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (counter.ContainsKey(matrix[i, j]))
            {
                counter[matrix[i, j]]++;
            }
            else
            {
                counter.Add(matrix[i, j], 1);
            }
        }
    }
}

Dictionary<int, int> counter = new Dictionary<int, int>();
int[,] matrix = CreateAndFillMatrix(4, 5, 0, 9);
PrintMatrix(matrix);
CountElementsInMatrix(matrix, counter);
Console.WriteLine();
foreach (int key in counter.Keys)
{
    Console.WriteLine($"There are {counter[key]} {key}'s");
}