using System;

struct Point
{
    public double x;
    public double y;
    public double r;
    public double theta;
    public double degrees;
}

class Program
{
    static void Main(string[] args)
    {        
        Point[] cartesianPoints = new Point[3];
        cartesianPoints[0].x = 1;
        cartesianPoints[0].y = 1;
        cartesianPoints[1].x = -2;
        cartesianPoints[1].y = 2;
        cartesianPoints[2].x = 3;
        cartesianPoints[2].y = -3;

        Point[] polarPoints = ConvertToPolar(cartesianPoints);

        Console.WriteLine("Декартовы точки:");
        foreach (Point cartesianPoint in cartesianPoints)
        {
            Console.WriteLine($"({cartesianPoint.x}, {cartesianPoint.y})");
        }

        Console.WriteLine("\n");

        Console.WriteLine("Полярные точки:");
        foreach (Point polarPoint in polarPoints)
        {
            Console.WriteLine($"({polarPoint.degrees})");
        }

        Console.ReadLine();
    }

    static Point[] ConvertToPolar(Point[] cartesianPoints)
    {
        Point[] polarPoints = new Point[cartesianPoints.Length];

        for (int i = 0; i < cartesianPoints.Length; i++)
        {
            double x = cartesianPoints[i].x;
            double y = cartesianPoints[i].y;

            double r = Math.Sqrt(x * x + y * y);
            double theta = Math.Atan2(y, x);
            double degrees = (180 / Math.PI) * theta;

            polarPoints[i].r = r;
            polarPoints[i].theta = theta;
            polarPoints[i].degrees = degrees;
        }

        return polarPoints;
    }
}
