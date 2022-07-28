// Задача 66: 
Console.WriteLine();
Console.WriteLine("Домашнее задание. Задача №66: Задайте значения M и N.");
Console.WriteLine("Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("***************************************************************************************");
Console.WriteLine();
Console.WriteLine("Задайте число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int start, int end)
{
       if (start == end)
        return end;
    return (start + SumNumbers(start + 1, end));
}
Console.WriteLine($"Сумма чисел от {M} до {N} равна {SumNumbers(M, N)}");
Console.WriteLine();
