double ThreeDimensionDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));  
}

Console.Write("Enter first x coordinate: ");
double xFirst = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter first y coordinate: ");
double yFirst = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter first z coordinate: ");
double zFirst = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second x coordinate: ");
double xSecond = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second y coordinate: ");
double ySecond = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second z coordinate: ");
double zSecond = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(ThreeDimensionDistance(xFirst, yFirst, zFirst, xSecond, ySecond, zSecond));