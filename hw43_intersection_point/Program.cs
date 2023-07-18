double[] IntersectionPoint(double k1, double b1, double k2, double b2) // NOTE: y = k1/k2 * x + b1/b2, NOT y = b1/b2 * x + k1/k2
{
    double[] intersectionPoint = new double[2];
    if (k1 != k2)
    {
        double intersectionX = (b2 - b1) / (k1 - k2);
        double intersectionY = k1 * intersectionX + b1;
        intersectionPoint[0] = intersectionX;
        intersectionPoint[1] = intersectionY;
        PrintArray(intersectionPoint);
    }
    else
    {
        Console.WriteLine("The lines are parallel");
    }
    return intersectionPoint;
}

void PrintArray(double[] array)
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

double[] intP = IntersectionPoint(5, 4, 1, 2);
