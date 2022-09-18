// Задача 43
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
CrossLine(k1, b1, k2, b2);

void CrossLine(double k1, double b1,double k2, double b2)
{
    if(k1==k2 && b1==b2)
    Console.WriteLine("Прямые совпадают");
    else if (k1==k2)
    Console.WriteLine("Прямые параллельны");
    else
    {
        double[] point = FindPoint(k1, b1, k2, b2);
        Console.WriteLine($"Точка пересечения заданных прямых: x = {point[0]}, y = {point[1]}");
    }
}

double[] FindPoint(double k1, double b1, double k2, double b2)

{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k1 * point[0] + b1;
    return point;
}