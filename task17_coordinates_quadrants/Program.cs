int CoordinatesQuadrants(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    else if (x < 0 && y > 0) return 2;
    else if (x < 0 && y < 0) return 3;
    else if (x > 0 && y < 0) return 4;
    else return 0;
}


Console.WriteLine(CoordinatesQuadrants(-1.5, 2.3));