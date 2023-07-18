int[,,] CreateRandomNonduplicate3DMatrix(int depth, int rows, int columns, int start, int end)
{
    int[,,] matrix = new int[depth, rows, columns];
    if (depth * rows * columns > end - start)
    {
        System.Console.WriteLine("Can't fill such big matrix");
    }
    else
    {
        List<int> numbers = new List<int>(); 
        for (int i = 0; i < depth; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                for (int k = 0; k < columns; k++)
                {
                    int ranNum = new Random().Next(start, end + 1);
                    while (numbers.Contains(ranNum))
                    {
                        ranNum = new Random().Next(start, end + 1);
                    }
                    numbers.Add(ranNum);
                    matrix[i, j, k] = ranNum;
                }
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        Console.Write($"[ ]\t");
        for (int i = 0; i < matrix.GetLength(2); i++)
        {
            Console.Write($"[{i}]\t");
        }
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            Console.Write($"[{i}]\t");
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                Console.Write(matrix[k, i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Depth: {k}");
        Console.WriteLine();
    }
}

// to check that all numbers are present only once
void CountElementsInMatrix(int[,,] matrix, Dictionary<int, int> counter)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (counter.ContainsKey(matrix[i, j, k]))
                {
                    counter[matrix[i, j, k]]++;
                }
                else
                {
                    counter.Add(matrix[i, j, k], 1);
                }
            }
        }
    }
}

int[,,] numbers = CreateRandomNonduplicate3DMatrix(4, 5, 3, 10, 99);
PrintMatrix(numbers);
Dictionary<int, int> counter = new Dictionary<int, int>();
CountElementsInMatrix(numbers, counter);
foreach (int key in counter.Keys)
{
    Console.WriteLine($"{key} is present {counter[key]} time(s)");
}