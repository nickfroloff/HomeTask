// Задача №43

Console.WriteLine("Домашнее задание. Задача №43: Напишите программу, которая найдёт точку пересечения двух прямых,");
Console.WriteLine("заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");
Console.WriteLine("значения b1, k1, b2 и k2 задаются пользователем.");

double accountX(double k1, double b1, double k2, double b2)
{
    return (b2 - b1) / (k1 - k2);
}
double accountY(double k1, double b1, double x)
{
    return k1 * x + b1;
}
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = accountX(k1, b1, k2, b2);
double y = accountY(k1, b1, x);
Console.WriteLine("Точка пересечения двух прямых: (" + x + ";" + y + ")");
