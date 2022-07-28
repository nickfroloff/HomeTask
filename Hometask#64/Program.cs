// Задача 64
Console.WriteLine();
Console.WriteLine("Домашнее задание. Задача №64: Задайте значения M и N.");
Console.WriteLine("Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
Console.WriteLine("**********************************************************************************");
Console.WriteLine();
Console.WriteLine("Задайте число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число N: ");
int N = Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
       if (start == end)
        return start.ToString();
    return (start + ", " + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(M, N));
Console.WriteLine();