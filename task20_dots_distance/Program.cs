double DotsDistance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));  
}

Console.Write("Enter first x coordinate: ");
double xFirst = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter first y coordinate: ");
double yFirst = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second x coordinate: ");
double xSecond = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second y coordinate: ");
double ySecond = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(DotsDistance(xFirst, yFirst, xSecond, ySecond));