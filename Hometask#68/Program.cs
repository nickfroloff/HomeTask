// Задача 68
Console.WriteLine();
Console.WriteLine("Домашнее задание. Задача №68:Напишите программу вычисления функции Аккермана с помощью рекурсии");
Console.WriteLine("при условии, что два неотрицательных числа m и n.");
Console.WriteLine("************************************************************************************************");
Console.WriteLine();
Console.WriteLine("Задайте число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int FunctionAkkermana(int m, int n)
{
    if (m < 0 || n < 0)
        return 0;
    if (m == 0)
        return n + 1;
    else if ((m > 0) && (n == 0))
        return FunctionAkkermana(m - 1, 1);
    else
        return FunctionAkkermana(m - 1, FunctionAkkermana(m, n - 1));
}
Console.WriteLine($"Функция Аккермана для чисел {m} и {n} равна {FunctionAkkermana(m, n)}");
Console.WriteLine();