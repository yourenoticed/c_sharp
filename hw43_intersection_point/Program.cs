int[] IntersectionPoint(int b1, int k1, int b2, int k2)
{
    int intersectionX = (b2 - b1) / (k1 - k2);
    int intersectionY = k1 * intersectionX + b1;
    int[] intersectionPoint = {intersectionX, intersectionY};
    return intersectionPoint;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.WriteLine($"{array[i]}]");
        else
            Console.Write($"{array[i]}, ");
    }
}

PrintArray(IntersectionPoint(5, 4, 1, 2));