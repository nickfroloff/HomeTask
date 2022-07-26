// Задача №47

Console.WriteLine("Домашнее задание. Задача №47: Задайте двумерный массив размером m×n, ");
Console.WriteLine("заполненный случайными вещественными числами.");

Console.WriteLine("Количество строк массива (m): ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов массива (n): ");
int n=Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];

Random rnd = new Random();
for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        array[i,j] = rnd.NextDouble();
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}
