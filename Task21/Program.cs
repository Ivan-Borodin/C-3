Console.WriteLine("Введите координату x первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double Distance(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    double a = X2 - X1;
    double b = Y2 - Y1;
    double c = Z2 - Z1;
    double q = a * a + b * b + c * c;
    double dist = Math.Sqrt(q);
    return dist;
}
double d = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(d);
